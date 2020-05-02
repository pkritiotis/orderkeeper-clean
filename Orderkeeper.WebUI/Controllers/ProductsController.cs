using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orderkeeper.Core.Products;
using Orderkeeper.Core.Products.Commands.CreateProduct;
using Orderkeeper.Core.Products.Commands.DeleteProduct;
using Orderkeeper.Core.Products.Commands.UpdateProduct;

namespace Orderkeeper.Api.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> Get()
        {
            return await Mediator.Send(new GetProductsQuery());
        }

        [HttpGet("{Id}")]
        public async Task<GetProductResult> Get(Guid Id)
        {
            return await Mediator.Send(new GetProductQuery { Id = Id });
        }

        [HttpDelete("{Id}")]
        public async Task Delete(Guid Id)
        {
            await Mediator.Send(new DeleteProductCommand { ProductId = Id });
        }

        [HttpPut("{Id}")]
        public async Task Delete(Guid Id, UpdatedProductDto updatedProduct)
        {
            await Mediator.Send(new UpdateProductCommand { UpdatedProduct = updatedProduct});
        }

        [HttpPost]
        public async Task<Guid> Create( NewProductDto newProduct)
        {
            return await Mediator.Send(new CreateProductCommand { NewProduct = newProduct });
        }
    }
}
