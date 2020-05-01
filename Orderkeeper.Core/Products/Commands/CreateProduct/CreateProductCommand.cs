using MediatR;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public NewProductDto NewProduct { get; set; }
    }
}
