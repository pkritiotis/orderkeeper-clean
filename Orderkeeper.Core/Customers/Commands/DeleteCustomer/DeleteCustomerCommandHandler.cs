using AutoMapper;
using MediatR;
using Orderkeeper.Core.Customers.Commands.DeleteCustomer;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Orderkeeper.Core.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public DeleteCustomerCommandHandler(IRepository<Customer> customerRepository, IMapper mapper)
        {
            this._customerRepository = customerRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            await _customerRepository.DeleteByAsync(x => x.Id == request.CustomerId);
            return await Task.FromResult(Unit.Value);
        }

    }
}