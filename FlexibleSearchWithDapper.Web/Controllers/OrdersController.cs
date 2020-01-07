using FlexibleSearchWithDapper.Web.Data;
using FlexibleSearchWithDapper.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FlexibleSearchWithDapper.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderRepository, ILogger<OrdersController> logger)
        {
            this._logger = logger;
            this._orderRepository = orderRepository;
        }

        [HttpGet("{orderId}")]
        public Order GetOrder(int orderId)
        {
            return this._orderRepository.GetOrder(orderId);
        }
    }
}