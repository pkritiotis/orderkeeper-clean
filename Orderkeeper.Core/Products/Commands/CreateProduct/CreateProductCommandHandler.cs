using AutoMapper;
using MediatR;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orderkeeper.Core.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,Guid>
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IRepository<Product> productRepository, IMapper mapper)
        {
            this._productRepository = productRepository;
            this._mapper = mapper;
        }
        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return _productRepository.CreateAsync(
                _mapper.Map<Product>(request.NewProduct)
                );
        }

    }
}