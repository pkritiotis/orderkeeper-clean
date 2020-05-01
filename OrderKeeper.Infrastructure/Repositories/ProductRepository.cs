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
    public class ProductRepository : IRepository<Product>
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

        public async Task<Guid> CreateAsync(Product entity)
        {
            entity.Id = Guid.NewGuid();
            await _applicationDbContext.Products.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
            return entity.Id;
        }

        public Task DeleteByAsync(Expression<Func<Product, bool>> filter)
        {

            _applicationDbContext.Products.RemoveRange(_applicationDbContext.Products.Where(filter));
            return _applicationDbContext.SaveChangesAsync();
        }

        public IAsyncEnumerable<Product> GetAllAsync()
        {
            return  _applicationDbContext.Products.AsAsyncEnumerable();
        }

        public IAsyncEnumerable<Product> GetByAsync(Expression<Func<Product, bool>> filter)
        {
            return _applicationDbContext.Products.Where(filter).AsAsyncEnumerable();
        }

        public Task<Product> GetSingleByAsync(Expression<Func<Product, bool>> filter)
        {
            return _applicationDbContext.Products.SingleAsync(filter);
        }

        public Task UpdateByAsync(Expression<Func<Product, bool>> filter, Product entity)
        {
            _applicationDbContext.Products.Update(entity);
            return _applicationDbContext.SaveChangesAsync();
        }
    }
}
