using MediatR;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public Guid productId { get; set; }
    }
}
