using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using AutoMapper;

namespace ApiProjectX.Service.Services
{
    public class SeasonService : BaseService<SeasonEntity>, ISeasonService
    {
        private readonly IRepositoryWrapper _repository;
        public SeasonService(IRepositoryWrapper repository, IBaseRepository<SeasonEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }
    }
}
