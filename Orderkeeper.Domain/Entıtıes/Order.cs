using System;
using System.Collections.Generic;

namespace Orderkeeper.Domain.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateIssued { get; set; }
        public int CustomerId { get; set; }
        public double  TotalAmount { get; set; }
        public IEnumerable<OrderItem> OrderItems {get;set;}
        public Customer Customer { get; set; }
    }
}