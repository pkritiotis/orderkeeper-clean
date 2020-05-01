using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orderkeeper.Core.Products
{
    public class GetProductsQuery : IRequest<IEnumerable<ProductDto>>
    {

    }
}
