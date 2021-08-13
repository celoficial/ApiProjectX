using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public abstract class BaseService<T> : IBaseService<T>
    {
        private readonly IBaseRepository<T> _baseRepository;
        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<T> Create(T entity)
        {
            var create = await _baseRepository.Create(entity);
            return create;
        }

        public async Task CreateMany(IEnumerable<T> entities)
        {
            await _baseRepository.CreateMany(entities);
        }

        public async Task<Task> Delete(Guid id)
        {
            var entity = await _baseRepository.FindById(id);
            try
            {
                _baseRepository.Delete(entity);
                return Task.CompletedTask;
            }
            catch (GeneralException e)
            {
                return Task.FromException(e);
            }
        }

        public Task DeleteMany(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Exists(Guid id)
        {
            var entity = await _baseRepository.Exists(id);
            return entity;
        }

        public async Task<T> FindById(Guid id)
        {
            var entity = await _baseRepository.FindById(id);
            return entity;
        }

        public async Task<Task> Save()
        {
            try
            {
                await _baseRepository.Save();
                return Task.CompletedTask;
            }
            catch (GeneralException e)
            {
                return Task.FromException(e);
            }
        }

        public async Task<Task> Update(T entity)
        {
            try
            {
                await _baseRepository.Update(entity);
                return Task.CompletedTask;
            }
            catch (GeneralException e)
            {
                return Task.FromException(e);
            }
        }
    }
}
