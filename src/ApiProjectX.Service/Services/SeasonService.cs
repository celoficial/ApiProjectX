using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.Season;
using ApiProjectX.Domain.Responses.Season;
using AutoMapper;

namespace ApiProjectX.Service.Services
{
    public class SeasonService : BaseService<SeasonEntity, SeasonRequest, SeasonResponse>, ISeasonService
    {
        private readonly IRepositoryWrapper _repository;
        public SeasonService(IRepositoryWrapper repository, IBaseRepository<SeasonEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }
    }
}
