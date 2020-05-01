using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Products
{
    public class GetProductQuery : IRequest<GetProductResult>
    {
        public Guid Id { get; set; }
    }
}
