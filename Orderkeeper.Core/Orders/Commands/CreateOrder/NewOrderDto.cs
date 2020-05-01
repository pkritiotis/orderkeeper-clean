using AutoMapper;
using Orderkeeper.Core.Common;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Orders
{
    public class NewOrderDto : MapFrom<Order>
    {
        public Guid CustomerId { get; set; }
        public double TotalAmount { get; set; }
        public IEnumerable<NewOrderItemDto> OrderItems { get; set; }
    }
}
