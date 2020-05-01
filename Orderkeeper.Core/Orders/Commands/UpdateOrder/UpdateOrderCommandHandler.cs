using AutoMapper;
using MediatR;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orderkeeper.Core.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IRepository<Order> orderRepository, IMapper mapper)
        {
            this._orderRepository = orderRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            await _orderRepository.UpdateByAsync(x=> x.Id == request.UpdatedOrder.Id,
                _mapper.Map<Order>(request.UpdatedOrder)
                );
            return await Task.FromResult(Unit.Value);
        }

    }
}