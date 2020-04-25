using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Customers
{
    public class GetCustomersResult
    {
        public IEnumerable<CustomerDto> Customers { get; set; }
    }
}
