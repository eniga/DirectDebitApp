using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DirectDebitApi.Entities;
using MicroOrm.Dapper.Repositories;

namespace DirectDebitApi.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
    {
        protected DapperRepository<T> repository;

        public GenericRepository(DapperRepository<T> repo)
        {
            repository = repo;
        }

        public async Task<bool> AddAsync(T item)
        {
            return await repository.InsertAsync(item);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await repository.DeleteAsync(x => x.id == id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await repository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await repository.FindAllAsync();
        }

        public async Task<bool> UpdateAsync(T item)
        {
            return await repository.UpdateAsync(item);
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return repository.FindAsync(predicate);
        }

        public Task<int> AddBulkAsync(IEnumerable<T> items)
        {
            return repository.BulkInsertAsync(items);
        }
    }
}
