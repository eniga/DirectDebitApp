using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DirectDebitApi.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(object id);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<bool> AddAsync(T item);
        Task<int> AddBulkAsync(IEnumerable<T> items, IDbTransaction transaction = null);
        Task<bool> UpdateAsync(T item, params Expression<Func<T, object>>[] includes);
        Task<bool> DeleteAsync(int id);
        Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate, IDbTransaction transaction = null);
    }
}
