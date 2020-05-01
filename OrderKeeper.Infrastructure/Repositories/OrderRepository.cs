using Microsoft.EntityFrameworkCore;
using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using OrderKeeper.Infrastructure.Data.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Orderkeeper.Infrastructure
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public OrderRepository(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

        public async Task<Guid> CreateAsync(Order entity)
        {
            entity.Id = Guid.NewGuid();
            await _applicationDbContext.Orders.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
            return entity.Id;
        }

        public Task DeleteByAsync(Expression<Func<Order, bool>> filter)
        {

            _applicationDbContext.Orders.RemoveRange(_applicationDbContext.Orders.Where(filter));
            return _applicationDbContext.SaveChangesAsync();
        }

        public IAsyncEnumerable<Order> GetAllAsync()
        {
            return  _applicationDbContext.Orders.Include(x=>x.OrderItems).AsAsyncEnumerable();
        }

        public IAsyncEnumerable<Order> GetByAsync(Expression<Func<Order, bool>> filter)
        {
            return _applicationDbContext.Orders.Where(filter).Include(x=>x.OrderItems).AsAsyncEnumerable();
        }

        public Task<Order> GetSingleByAsync(Expression<Func<Order, bool>> filter)
        {
            return _applicationDbContext.Orders.Include(x => x.OrderItems).SingleAsync(filter);
        }

        public Task UpdateByAsync(Expression<Func<Order, bool>> filter, Order entity)
        {
            _applicationDbContext.Orders.Update(entity);
            return _applicationDbContext.SaveChangesAsync();
        }
    }
}
