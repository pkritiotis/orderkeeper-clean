using Orderkeeper.Core.Common;
using Orderkeeper.Domain.Entities;
using System;

namespace Orderkeeper.Core.Orders
{
    public class OrderItemDto : MapFrom<OrderItem>
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

    }
}