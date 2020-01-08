using System.Collections.Generic;
using FlexibleSearchWithDapper.Web.Models;

namespace FlexibleSearchWithDapper.Web.Data
{
    public interface IOrderRepository
    {
        Order GetOrder(int orderId);
        IEnumerable<Order> GetAllOrders();
        Order CreateOrder(Order order);
        IEnumerable<Order> SearchOrders(OrderSearchModel searchModel);
    }
}