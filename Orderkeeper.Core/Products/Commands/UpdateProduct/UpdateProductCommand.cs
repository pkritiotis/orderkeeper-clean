using MediatR;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest
    {
        public UpdatedProductDto UpdatedProduct { get; set; }
    }
}
