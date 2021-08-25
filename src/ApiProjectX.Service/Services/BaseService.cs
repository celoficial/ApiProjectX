using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Responses;
using ApiProjectX.Service.Exceptions;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public abstract class BaseService<T1, T2, T3> : IBaseService<T1,T2,T3>
    {
        private readonly IBaseRepository<T1> _baseRepository;
        protected readonly IMapper _mapper;

        public BaseService(IBaseRepository<T1> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<GenericResult> Create(T2 entity)
        {
            var result = new GenericResult();
            try
            {
                var c = _mapper.Map<T2, T1>(entity);
                await _baseRepository.Create(c);
                result.Message = "deu bom dimais";
                return result;
            }
            catch (GeneralException e)
            {
                result.Message = "deu ruim F";
                result.Success = false;
                return result;
            }
        }

        public async Task<GenericResult> CreateMany(IEnumerable<T2> entities)
        {
            var result = new GenericResult();
            try
            {
                var c = _mapper.Map<IEnumerable<T2>, IEnumerable<T1>>(entities);
                await _baseRepository.CreateMany(c);
                result.Message = "criou";
                return result;

            }
            catch (GeneralException e)
            {
                result.Message = "nao criou";
                result.Success = false;
                return result;
            }
        }

        public async Task<GenericResult> Delete(Guid id)
        {
            var result = new GenericResult();
            try
            {
                var entity = await _baseRepository.FindById(id);
                var c = _mapper.Map<T1, T3>(entity);
                _baseRepository.Delete(entity);
                result.Message = "deletou";
                result.Data = c;
                return result;
            }
            catch (GeneralException e)
            {
                result.Message = "nao deletou";
                result.Success = false;
                return result;
            }
        }

        public Task DeleteMany(IEnumerable<T1> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<GenericResult> Exists(Guid id)
        {
            var result = new GenericResult();
            try
            {
                var entity = await _baseRepository.Exists(id);
                result.Message = "achou";

                return result;

            }
            catch (GeneralException e)
            {
                result.Message = "nao achou";
                result.Success = false;
                return result;

            }
        }

        public async Task<GenericResult> FindById(Guid id)
        {

            var result = new GenericResult();
            try
            {

                var entity = await _baseRepository.FindById(id);
                var c = _mapper.Map<T1, T3>(entity);

                result.Message = "achou id";
                result.Data = c;
                return result;


            }
            catch (GeneralException e)
            {
                result.Message = "nao achou id";
                result.Success = false;
                return result;
            }
        }

        public async Task<GenericResult> GetAll()
        {
            var result = new GenericResult();
            try
            {
                var e = await _baseRepository.FindAll();
                var c = _mapper.Map<IEnumerable<T1>, IEnumerable<T3>>(e);
                result.Message = "deu get";
                result.Data = c;
                return result;

            }
            catch (GeneralException e)
            {
                result.Message = "nao deu get";
                result.Success = false;
                return result;

            }
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

        public async Task<GenericResult> Update(T2 entity)
        {
            var result = new GenericResult();
            try
            {
                var c = _mapper.Map<T2, T1>(entity);
                await _baseRepository.Update(c);
                result.Message = "atualizou";
                return result;
            }
            catch (GeneralException e)
            {
                result.Message = "nao atualizou";
                result.Success = false;
                return result;
            }
        }

    }
}
