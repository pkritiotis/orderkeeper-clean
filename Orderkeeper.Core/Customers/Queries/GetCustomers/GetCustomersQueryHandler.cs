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
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, GetCustomersResult>
    {
        private readonly IRepository<Customer> _repository;
        private readonly IMapper _mapper;

        public GetCustomersQueryHandler(IRepository<Customer> repository, IMapper mapper)
        {
            this._repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCustomersResult> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            return new GetCustomersResult
            {
                Customers = _mapper.Map<IEnumerable<CustomerDto>>(await _repository.GetAllAsync().ToListAsync())
            };
        }
    }
}
