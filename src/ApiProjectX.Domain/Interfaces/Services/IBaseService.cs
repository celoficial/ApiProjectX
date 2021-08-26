using ApiProjectX.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IBaseService<T1, T2, T3>
    {
        Task<GenericResult> Create(T2 entity);
        Task<GenericResult> CreateMany(IEnumerable<T2> entities);
        Task<GenericResult> Delete(Guid id);
        Task DeleteMany(IEnumerable<T1> entities);
        Task<GenericResult> Exists(Guid id);
        Task<GenericResult> FindById(Guid id);
        Task<GenericResult> GetAll();
        Task<Task> Save();
        Task<GenericResult> Update(T2 entity);
    }
}