using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;

namespace ApiProjectX.Service.Services
{
    public class WatchLaterService : BaseService<WatchLaterEntity>, IWatchLaterService
    {
        private readonly IRepositoryWrapper _repository;

        public WatchLaterService(IRepositoryWrapper repository, IBaseRepository<WatchLaterEntity> baseRepository) : base(baseRepository)
        {
            _repository = repository;
        }
    }
}
