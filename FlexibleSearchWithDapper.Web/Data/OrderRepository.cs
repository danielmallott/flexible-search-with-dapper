using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using FlexibleSearchWithDapper.Web.Models;
using Microsoft.Extensions.Configuration;

namespace FlexibleSearchWithDapper.Web.Data
{
    public class OrderRepository : IOrderRepository
    {
        private IConfiguration _configuration;

        private IDbConnection Connection
        {
            get => new SqlConnection(this._configuration.GetConnectionString("default"));
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
    }
}