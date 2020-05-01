using AutoMapper;
using Orderkeeper.Core.Common;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Products
{
    public class NewProductDto : MapFrom<Product>
    {
        public string Name { get; set; }
        public double DefaultPrice { get; set; }
        public string PriceCurrency { get; set; }
        public string DefaultUnit { get; set; }
    }
}
