using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Customers
{
    public class GetCustomersQuery : IRequest<IEnumerable<CustomerDto>>
    {

    }
}
