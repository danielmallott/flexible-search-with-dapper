using System.Collections.Generic;
using FlexibleSearchWithDapper.Web.Models;

namespace FlexibleSearchWithDapper.Web.Data
{
    /// <summary>
    /// Interface that describes an Order Repository
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Gets the Order with <paramref name="orderId"/>.
        /// </summary>
        /// <param name="orderId">Order Id.</param>
        /// <returns>Order or <c>null</c> if none found.</returns>
        Order GetOrder(int orderId);
        
        /// <summary>
        /// Gets all orders from the database.
        /// </summary>
        /// <returns>All Orders.</returns>
        IEnumerable<Order> GetAllOrders();
        
        /// <summary>
        /// Creates a new order using the supplied <paramref name="order"/>.
        /// </summary>
        /// <param name="order">Order to create.</param>
        /// <returns>Created Order.</returns>
        Order CreateOrder(Order order);
        
        /// <summary>
        /// Searches Orders using the supplied <paramref name="searchModel"/>.
        /// </summary>
        /// <param name="searchModel">Search Model to use.</param>
        /// <returns>Found records or <c>null</c> if none found.</returns>
        IEnumerable<Order> SearchOrders(OrderSearchModel searchModel);
    }
}