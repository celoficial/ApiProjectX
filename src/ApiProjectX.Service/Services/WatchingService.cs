using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using AutoMapper;

namespace ApiProjectX.Service.Services
{
    public class WatchingService : BaseService<WatchingEntity>, IWatchingService
    {
        private readonly IRepositoryWrapper _repository;
        public WatchingService(IRepositoryWrapper repository, IBaseRepository<WatchingEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }
    }
}
