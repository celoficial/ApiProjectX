using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;

namespace ApiProjectX.Service.Services
{
    public class WatchingService : BaseService<WatchingEntity>, IWatchingService
    {
        private readonly IRepositoryWrapper _repository;
        public WatchingService(IRepositoryWrapper repository, IBaseRepository<WatchingEntity> baseRepository) : base(baseRepository)
        {
            _repository = repository;
        }
    }
}
