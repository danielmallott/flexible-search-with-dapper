using FlexibleSearchWithDapper.Web.Models;

namespace FlexibleSearchWithDapper.Web.Data
{
    public interface IOrderRepository
    {
        Order GetOrder(int orderId);
    }
}