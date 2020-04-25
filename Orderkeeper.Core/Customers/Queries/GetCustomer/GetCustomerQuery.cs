using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Customers
{
    public class GetCustomerQuery : IRequest<GetCustomerResult>
    {
        public int Id { get; set; }
    }
}
