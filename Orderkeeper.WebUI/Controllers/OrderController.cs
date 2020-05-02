using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orderkeeper.Core.Orders;
using Orderkeeper.Core.Orders.Commands.CreateOrder;
using Orderkeeper.Core.Orders.Commands.DeleteOrder;
using Orderkeeper.Core.Orders.Commands.UpdateOrder;

namespace Orderkeeper.Api.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderDto>> Get()
        {
            return await Mediator.Send(new GetOrdersQuery());
        }

        [HttpGet("{Id}")]
        public async Task<GetOrderResult> Get(Guid Id)
        {
            return await Mediator.Send(new GetOrderQuery { Id = Id });
        }

        [HttpDelete("{Id}")]
        public async Task Delete(Guid Id)
        {
            await Mediator.Send(new DeleteOrderCommand { OrderId = Id });
        }

        [HttpPut("{Id}")]
        public async Task Delete(Guid Id, UpdatedOrderDto updatedOrder)
        {
            await Mediator.Send(new UpdateOrderCommand { UpdatedOrder = updatedOrder});
        }

        [HttpPost]
        public async Task<Guid> Create( NewOrderDto newOrder)
        {
            return await Mediator.Send(new CreateOrderCommand { NewOrder = newOrder });
        }
    }
}
