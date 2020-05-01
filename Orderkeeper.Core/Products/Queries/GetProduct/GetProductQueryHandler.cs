using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orderkeeper.Core.Products
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductResult>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            this._repository = repository;
            _mapper = mapper;
        }

        public async Task<GetProductResult> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return new GetProductResult
            {
                Product = _mapper.Map<ProductDto>(await _repository.GetSingleByAsync(x=>x.Id == request.Id))
            };
        }
    }
}
