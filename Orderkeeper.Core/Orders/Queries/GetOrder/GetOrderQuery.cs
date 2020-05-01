using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Orders
{
    public class GetOrderQuery : IRequest<GetOrderResult>
    {
        public Guid Id { get; set; }
    }
}
