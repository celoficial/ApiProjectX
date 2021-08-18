using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;

namespace ApiProjectX.Service.Services
{
    public class SeasonService : BaseService<SeasonEntity>, ISeasonService
    {
        private readonly IRepositoryWrapper _repository;
        public SeasonService(IRepositoryWrapper repository, IBaseRepository<SeasonEntity> baseRepository) : base(baseRepository)
        {
            _repository = repository;
        }
    }
}
