using ApiProjectX.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public abstract class BaseService<T> : IBaseService<T>
    {
        public BaseService()
        {

        }

        public Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> CreateMany(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMany(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(Guid id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
