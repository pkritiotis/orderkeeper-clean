using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Customers
{
    public class GetCustomerQuery : IRequest<GetCustomerResult>
    {
        public Guid Id { get; set; }
    }
}
