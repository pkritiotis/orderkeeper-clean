using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Orderkeeper.Core.Interfaces
{
    public interface IRepository<T>
        where T : class
    {
        IAsyncEnumerable<T> GetAllAsync();
        IAsyncEnumerable<T> GetByAsync(Expression<Func<T, bool>> filter);
        Task<T> GetSingleByAsync(Expression<Func<T, bool>> filter);
        Task<Guid> CreateAsync(T entity);
        Task UpdateByAsync(Expression<Func<T, bool>> filter,T entity);
        Task DeleteByAsync(Expression<Func<T, bool>> filter);
    }

}
