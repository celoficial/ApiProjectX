using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using AutoMapper;

namespace ApiProjectX.Service.Services
{
    public class WatchLaterService : BaseService<WatchLaterEntity>, IWatchLaterService
    {
        private readonly IRepositoryWrapper _repository;

        public WatchLaterService(IRepositoryWrapper repository, IBaseRepository<WatchLaterEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }
    }
}
