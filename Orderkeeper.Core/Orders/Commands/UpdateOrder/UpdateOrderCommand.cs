using MediatR;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommand : IRequest
    {
        public UpdatedOrderDto UpdatedOrder { get; set; }
    }
}
