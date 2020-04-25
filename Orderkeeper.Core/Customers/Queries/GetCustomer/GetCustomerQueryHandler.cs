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

namespace Orderkeeper.Core.Customers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, GetCustomerResult>
    {
        private readonly IRepository<Customer> _repository;
        private readonly IMapper _mapper;

        public GetCustomerQueryHandler(IRepository<Customer> repository, IMapper mapper)
        {
            this._repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCustomerResult> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            return new GetCustomerResult
            {
                Customer = _mapper.Map<CustomerDto>(await _repository.GetSingleByAsync(x=>x.Id == request.Id))
            };
        }
    }
}
