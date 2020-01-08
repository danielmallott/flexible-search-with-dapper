using System.Collections.Generic;
using System.Net.Mime;
using FlexibleSearchWithDapper.Web.Data;
using FlexibleSearchWithDapper.Web.Models;
using Microsoft.AspNetCore.Http;
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
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public Order GetOrder(int orderId)
        {
            return this._orderRepository.GetOrder(orderId);
        }

        [HttpGet("all")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IEnumerable<Order> GetAllOrders()
        {
            return this._orderRepository.GetAllOrders();
        }

        [HttpPost()]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Order> CreateOrder([FromBody] Order order)
        {
            var created = this._orderRepository.CreateOrder(order);
            return CreatedAtAction(nameof(GetOrder), new { id = created.OrderId}, created);
        }

        [HttpGet()]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Order> SearchOrders([FromQuery]OrderSearchModel searchModel)
        {
            return this._orderRepository.SearchOrders(searchModel);
        }
    }
}