using Orderkeeper.Core.Common;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Orderkeeper.Core.Orders
{
    public class OrderDto : MapFrom<Order>
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public double TotalAmount { get; set; }
        public IEnumerable<OrderItemDto> OrderItems { get; set; }
    }
}