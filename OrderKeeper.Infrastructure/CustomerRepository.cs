using Orderkeeper.Core.Interfaces;
using Orderkeeper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Orderkeeper.Infrastructure
{
    public class CustomerRepository : IRepository<Customer>
    {
        public Task<Customer> CreateByAsync(Customer entity)
        {
            return Task.FromResult(new Customer() { Id = 1 });
        }

        public Task<Customer> DeleteByAsync(Expression<Func<Customer, bool>> filter)
        {
            return Task.FromResult(new Customer() { Id = 1 });

        }

        public async IAsyncEnumerable<Customer> GetAllAsync()
        {
            for(int i = 0; i < 2; i++)
            {
                yield return new Customer() { Id = i };
            }
        }

        public async IAsyncEnumerable<Customer> GetByAsync(Expression<Func<Customer, bool>> filter)
        {
            for (int i = 0; i < 2; i++)
            {
                yield return new Customer() { Id = i };
            }
        }

        public Task<Customer> GetSingleByAsync(Expression<Func<Customer, bool>> filter)
        {
            return Task.FromResult(new Customer() { Id = 1 });
        }

        public Task<Customer> UpdateByAsync(Expression<Func<Customer, bool>> filter, Customer entity)
        {
            return Task.FromResult(new Customer() { Id = 1 });
        }
    }
}
