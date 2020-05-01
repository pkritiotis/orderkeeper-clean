using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Orders
{
    public class GetOrdersQuery : IRequest<IEnumerable<OrderDto>>
    {

    }
}
