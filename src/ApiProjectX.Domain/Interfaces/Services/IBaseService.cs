using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IBaseService<T>
    {
        Task<T> Create(T entity);
        Task CreateMany(IEnumerable<T> entities);
        Task<Task> Delete(Guid id);
        Task DeleteMany(IEnumerable<T> entities);
        Task<bool> Exists(Guid id);
        Task<T> FindById(Guid id);
        Task<Task> Save();
        Task<Task> Update(T entity);
    }
}