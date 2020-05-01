using AutoMapper;
using MediatR;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orderkeeper.Core.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand,Guid>
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IRepository<Order> orderRepository, IMapper mapper)
        {
            this._orderRepository = orderRepository;
            this._mapper = mapper;
        }
        public Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            return _orderRepository.CreateAsync(
                _mapper.Map<Order>(request.NewOrder)
                );
        }

    }
}