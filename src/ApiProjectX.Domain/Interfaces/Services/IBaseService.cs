using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IBaseService<T>
    {
        Task<T> Create(T entity);
        Task<T> CreateMany(IEnumerable<T> entities);
        Task Delete(Guid Id);
        Task DeleteMany(IEnumerable<T> entities);
        Task<bool> Exists(Guid id);
        Task<List<T>> FindById(Guid id);
        Task Save();
        Task<T> Update(Guid id, T entity);
    }
}