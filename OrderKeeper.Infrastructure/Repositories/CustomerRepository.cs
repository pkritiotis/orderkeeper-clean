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
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CustomerRepository(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

        public async Task<Guid> CreateAsync(Customer entity)
        {
            entity.Id = Guid.NewGuid();
            await _applicationDbContext.Customers.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
            return entity.Id;
        }

        public Task DeleteByAsync(Expression<Func<Customer, bool>> filter)
        {

            _applicationDbContext.Customers.RemoveRange(_applicationDbContext.Customers.Where(filter));
            return _applicationDbContext.SaveChangesAsync();
        }

        public IAsyncEnumerable<Customer> GetAllAsync()
        {
            return  _applicationDbContext.Customers.AsAsyncEnumerable();
        }

        public IAsyncEnumerable<Customer> GetByAsync(Expression<Func<Customer, bool>> filter)
        {
            return _applicationDbContext.Customers.Where(filter).AsAsyncEnumerable();
        }

        public Task<Customer> GetSingleByAsync(Expression<Func<Customer, bool>> filter)
        {
            return _applicationDbContext.Customers.SingleAsync(filter);
        }

        public Task UpdateByAsync(Expression<Func<Customer, bool>> filter, Customer entity)
        {
            _applicationDbContext.Customers.Update(entity);
            return _applicationDbContext.SaveChangesAsync();
        }
    }
}
