using AutoMapper;
using MediatR;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orderkeeper.Core.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand,Guid>
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(IRepository<Customer> customerRepository, IMapper mapper)
        {
            this._customerRepository = customerRepository;
            this._mapper = mapper;
        }
        public Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return _customerRepository.CreateAsync(
                _mapper.Map<Customer>(request.NewCustomer)
                );
        }

    }
}