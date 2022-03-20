using Implement_RabbitMQ.Interface;
using Implement_RabbitMQ_Producer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Implement_RabbitMQ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IMessageProducer _messagePublisher;
        public OrdersController(IMessageProducer messagePublisher)
        {
            _messagePublisher = messagePublisher;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderDto orderDto)
        {
            #region TODO Save Order
            //Order order = new()
            //{
            //    ProductName = orderDto.ProductName,
            //    Price = orderDto.Price,
            //    Quantity = orderDto.Quantity
            //};
            //_context.Order.Add(order);
            //await _context.SaveChangesAsync(); 
            #endregion

            _messagePublisher.SendMessage(orderDto);

            return Ok(new { id = Guid.NewGuid() });
        }
    }
}
