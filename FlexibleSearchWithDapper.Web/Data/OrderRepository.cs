using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;
using FlexibleSearchWithDapper.Web.Core;
using FlexibleSearchWithDapper.Web.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace FlexibleSearchWithDapper.Web.Data
{
    /// <summary>
    /// Order Repository implementation.
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        private readonly IConfiguration _configuration;

        private IDbConnection Connection => new SqlConnection(this._configuration["ConnectionString:default"]);

        /// <summary>
        /// Instantiates a new <see cref="OrderRepository"/> using the supplied parameters.
        /// </summary>
        /// <param name="configuration">Configuration to use.</param>
        public OrderRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        /// <summary>
        /// Gets the Order with <paramref name="orderId"/>.
        /// </summary>
        /// <param name="orderId">Order Id.</param>
        /// <returns>Order or <c>null</c> if none found.</returns>
        public Order GetOrder(int orderId)
        {
            using (var connection = Connection)
            {
                return connection.Get<Order>(orderId);
            }
        }

        /// <summary>
        /// Gets all orders from the database.
        /// </summary>
        /// <returns>All Orders.</returns>
        public IEnumerable<Order> GetAllOrders()
        {
            using (var connection = Connection)
            {
                return connection.GetAll<Order>();
            }
        }

        /// <summary>
        /// Creates a new order using the supplied <paramref name="order"/>.
        /// </summary>
        /// <param name="order">Order to create.</param>
        /// <returns>Created Order.</returns>
        public Order CreateOrder(Order order)
        {
            using (var connection = Connection)
            {
                var newOrderId = connection.Insert(order);
                return connection.Get<Order>(newOrderId);
            }
        }

        /// <summary>
        /// Searches Orders using the supplied <paramref name="searchModel"/>.
        /// </summary>
        /// <param name="searchModel">Search Model to use.</param>
        /// <returns>Found records or <c>null</c> if none found.</returns>
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
            if (searchModel.CustomerId.HasValue)
            {
                parameters.Add("@customerID", searchModel.CustomerId.Value);
            }

            if (searchModel.SalesPersonId.HasValue)
            {
                parameters.Add("@salesPersonID", searchModel.SalesPersonId.Value);
            }

            if (searchModel.ContactPersonId.HasValue)
            {
                parameters.Add("@contactPersonID", searchModel.ContactPersonId.Value);
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

            if (searchModel.StockItemId.HasValue)
            {
                parameters.Add("@stockItemID", searchModel.StockItemId.Value);
            }

            if (!string.IsNullOrWhiteSpace(searchModel.Description))
            {
                parameters.Add("@description", searchModel.Description);
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