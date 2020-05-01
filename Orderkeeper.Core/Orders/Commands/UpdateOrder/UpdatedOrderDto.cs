using Orderkeeper.Core.Common;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Orders
{
    public class UpdatedOrderDto : MapFrom<Order>
    {
        public Guid Id { get; set; }
        public int CustomerId { get; set; }
        public double TotalAmount { get; set; }
        public IEnumerable<OrderItemDto> OrderItems { get; set; }
    }
}
