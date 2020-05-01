using System;
using System.Collections.Generic;

namespace Orderkeeper.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public double  TotalAmount { get; set; }
        public IEnumerable<OrderItem> OrderItems {get;set;}
        public Customer Customer { get; set; }
    }
}