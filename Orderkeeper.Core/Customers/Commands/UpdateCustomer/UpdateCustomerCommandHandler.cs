using AutoMapper;
using MediatR;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orderkeeper.Core.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(IRepository<Customer> customerRepository, IMapper mapper)
        {
            this._customerRepository = customerRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            await _customerRepository.UpdateByAsync(x=> x.Id == request.UpdatedCustomer.Id,
                _mapper.Map<Customer>(request.UpdatedCustomer)
                );
            return await Task.FromResult(Unit.Value);
        }

    }
}