using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using FlexibleSearchWithDapper.Web.Core;
using FlexibleSearchWithDapper.Web.Models;
using Microsoft.Extensions.Configuration;

namespace FlexibleSearchWithDapper.Web.Data
{
    public class OrderRepository : IOrderRepository
    {
        private IConfiguration _configuration;

        private IDbConnection Connection
        {
            get => new SqlConnection(this._configuration["ConnectionString:default"]);
        }
        
        public OrderRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public Order GetOrder(int orderId)
        {
            using (var connection = Connection)
            {
                return connection.Get<Order>(orderId);
            }
        }

        public IEnumerable<Order> GetAllOrders()
        {
            using (var connection = Connection)
            {
                return connection.GetAll<Order>();
            }
        }

        public Order CreateOrder(Order order)
        {
            using (var connection = Connection)
            {
                var newOrderId = connection.Insert(order);
                return connection.Get<Order>(newOrderId);
            }
        }

        public IEnumerable<Order> SearchOrders(OrderSearchModel searchModel)
        {
            var mapper = new EntityOneToManyMapper<Order, OrderLine, int>()
            {
                AddChildAction = (order, orderLine) =>
                {
                    if (order.OrderLines == null)
                    {
                        order.OrderLines = new HashSet<OrderLine>();
                    }

                    order.OrderLines.Add(orderLine);
                },
                ParentKey = (order) => order.OrderId
            };
            
            
            var parameters = new DynamicParameters();
            if (searchModel.CustomerID.HasValue)
            {
                parameters.Add("@customerID", searchModel.CustomerID.Value);
            }

            if (searchModel.SalesPersonID.HasValue)
            {
                parameters.Add("@salesPersonID", searchModel.SalesPersonID.Value);
            }

            if (searchModel.ContactPersonID.HasValue)
            {
                parameters.Add("@contactPersonID", searchModel.ContactPersonID.Value);
            }

            if (searchModel.OrderDate.HasValue)
            {
                parameters.Add("@orderDate", searchModel.OrderDate.Value, DbType.Date);
            }

            if (searchModel.ExpectedDeliveryDate.HasValue)
            {
                parameters.Add("@expectedDeliveryDate", searchModel.ExpectedDeliveryDate.Value, DbType.Date);
            }

            if (!string.IsNullOrWhiteSpace(searchModel.CustomerPurchaseOrderNumber))
            {
                parameters.Add("@customerPurchaseOrderNumber", searchModel.CustomerPurchaseOrderNumber);
            }

            if (searchModel.Quantity.HasValue)
            {
                parameters.Add("@quantity", searchModel.Quantity.Value);
            }

            if (searchModel.UnitPrice.HasValue)
            {
                parameters.Add("@unitPrice", searchModel.UnitPrice.Value, DbType.Decimal);
            }

            using (var connection = Connection)
            {
                return connection.Query<Order, OrderLine, Order>("Sales.SearchOrders", param: parameters,
                    map: mapper.Map, splitOn: "OrderLineID", commandType: CommandType.StoredProcedure).Where(result => result != null);
            }
        }
    }
}