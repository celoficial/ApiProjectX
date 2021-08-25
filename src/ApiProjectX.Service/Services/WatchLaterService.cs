using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.WatchLater;
using ApiProjectX.Domain.Responses;
using ApiProjectX.Domain.Responses.WatchLater;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public class WatchLaterService : BaseService<WatchLaterEntity, WatchLaterRequest, WatchLaterResponse>, IWatchLaterService
    {
        private readonly IRepositoryWrapper _repository;

        public WatchLaterService(IRepositoryWrapper repository, IBaseRepository<WatchLaterEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }
        public async Task<GenericResult> GetAllResponse()
        {
            var entities = await _repository.WatchLater.FindAll();

            var entities2 = _mapper.Map<IEnumerable<WatchLaterEntity>, IEnumerable<WatchLaterAllResponse>>(entities);

            return new GenericResult("deu certo", true, entities2);
        }
    }
}
