using AutoMapper;
using MediatR;
using Orderkeeper.Core.Products.Commands.DeleteProduct;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Orderkeeper.Core.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IRepository<Product> productRepository, IMapper mapper)
        {
            this._productRepository = productRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _productRepository.DeleteByAsync(x => x.Id == request.productId);
            return await Task.FromResult(Unit.Value);
        }

    }
}