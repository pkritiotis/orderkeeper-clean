﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orderkeeper.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double DefaultPrice { get; set; }
        public string PriceCurrency { get; set; }
        public string DefaultUnit { get; set; }
        public virtual IEnumerable<OrderItem> OrderItems {get;set;}
    }
}
