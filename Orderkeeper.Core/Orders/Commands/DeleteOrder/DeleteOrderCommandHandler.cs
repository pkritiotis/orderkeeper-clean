using AutoMapper;
using MediatR;
using Orderkeeper.Core.Orders.Commands.DeleteOrder;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Orderkeeper.Core.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand>
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IMapper _mapper;

        public DeleteOrderCommandHandler(IRepository<Order> orderRepository, IMapper mapper)
        {
            this._orderRepository = orderRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            await _orderRepository.DeleteByAsync(x => x.Id == request.orderId);
            return await Task.FromResult(Unit.Value);
        }

    }
}