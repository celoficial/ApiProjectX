using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.Watch;
using ApiProjectX.Domain.Responses.Watch;
using AutoMapper;

namespace ApiProjectX.Service.Services
{
    public class WatchService : BaseService<WatchEntity, WatchRequest, WatchResponse>, IWatchService
    {
        private readonly IRepositoryWrapper _repository;
        public WatchService(IRepositoryWrapper repository, IBaseRepository<WatchEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }
    }
}
