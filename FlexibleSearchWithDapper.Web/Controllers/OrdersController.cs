using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using FlexibleSearchWithDapper.Web.Data;
using FlexibleSearchWithDapper.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FlexibleSearchWithDapper.Web.Controllers
{
    /// <summary>
    /// Orders Controller.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IOrderRepository _orderRepository;

        /// <summary>
        /// Instantiates a new <see cref="OrdersController"/> using the supplied parameters.
        /// </summary>
        /// <param name="orderRepository">Order Repository to use.</param>
        /// <param name="logger">Logger to use.</param>
        public OrdersController(IOrderRepository orderRepository, ILogger<OrdersController> logger)
        {
            this._logger = logger;
            this._orderRepository = orderRepository;
        }

        /// <summary>
        /// Gets the Order with <paramref name="orderId"/>
        /// </summary>
        /// <param name="orderId">Order Id to get an Order for.</param>
        /// <returns>Requested Order or <c>null</c> if none found.</returns>
        [HttpGet("{orderId}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<Order> GetOrder(int orderId)
        {
            try
            {
                return this._orderRepository.GetOrder(orderId);
            }
            catch (Exception ex)
            {
                this._logger.LogError(exception: ex, message: "Error occurred.");
                return BadRequest("Error occurred.");
            }
        }

        /// <summary>
        /// Gets all Orders.
        /// </summary>
        /// <returns>All Orders.</returns>
        [HttpGet("all")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<Order>> GetAllOrders()
        {
            try
            {
                return this._orderRepository.GetAllOrders().ToList();
            }
            catch (Exception ex)
            {
                this._logger.LogError(exception: ex, message: "Error occurred.");
                return BadRequest("Error occurred.");
            }
            
        }

        /// <summary>
        /// Creates an order using the passed <paramref name="order"/>.
        /// </summary>
        /// <param name="order">Order to create.</param>
        /// <returns>Created Order.</returns>
        [HttpPost()]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Order> CreateOrder([FromBody] Order order)
        {
            try
            {
                var created = this._orderRepository.CreateOrder(order);
                return CreatedAtAction(nameof(GetOrder), new { id = created.OrderId}, created);
            }
            catch (Exception ex)
            {
                this._logger.LogError(exception: ex, message: "Error occurred.");
                return BadRequest("Error occurred.");
            }
        }

        /// <summary>
        /// Searches orders.
        /// </summary>
        /// <param name="searchModel">Search model.</param>
        /// <returns>Found orders or <c>null</c> if none found.</returns>
        [HttpGet()]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Order>> SearchOrders([FromQuery]OrderSearchModel searchModel)
        {
            try
            {
                return this._orderRepository.SearchOrders(searchModel).ToList();
            }
            catch (Exception ex)
            {
                this._logger.LogError(exception: ex, message: "Error occurred.");
                return BadRequest("Error occurred.");
            }
        }
    }
}