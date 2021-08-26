using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T>
    {
        Task<T> Create(T entity);
        Task CreateMany(IEnumerable<T> entities);
        void Delete(T entity);
        void DeleteMany(IEnumerable<T> entities);
        Task<bool> Exists(object id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression, int? skip = null, int? take = null, IEnumerable<string> includes = null);
        Task<IEnumerable<T>> FindAll(IEnumerable<string> includes = null);
        Task<T> FindById(Guid id, IEnumerable<string> includes = null);
        Task<T> FindSingle(Expression<Func<T, bool>> expression, IEnumerable<string> includes = null);
        Task Save();
        Task Update(T entity);
    }
}