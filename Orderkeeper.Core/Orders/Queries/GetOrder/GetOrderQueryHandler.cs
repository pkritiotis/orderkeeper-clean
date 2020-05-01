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

namespace Orderkeeper.Core.Orders
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, GetOrderResult>
    {
        private readonly IRepository<Order> _repository;
        private readonly IMapper _mapper;

        public GetOrderQueryHandler(IRepository<Order> repository, IMapper mapper)
        {
            this._repository = repository;
            _mapper = mapper;
        }

        public async Task<GetOrderResult> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            return new GetOrderResult
            {
                Order = _mapper.Map<OrderDto>(await _repository.GetSingleByAsync(x=>x.Id == request.Id))
            };
        }
    }
}
