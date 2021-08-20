using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;

namespace ApiProjectX.Service.Services
{
    public class EpisodeService : BaseService<EpisodeEntity>, IEpisodeService
    {
        private readonly IRepositoryWrapper _repository;
        public EpisodeService(IRepositoryWrapper repository, IBaseRepository<EpisodeEntity> baseRepository) : base(baseRepository)
        {
            _repository = repository;
        }
    }
}
