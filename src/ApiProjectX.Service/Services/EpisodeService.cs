using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.Episode;
using ApiProjectX.Domain.Responses.Episode;
using AutoMapper;

namespace ApiProjectX.Service.Services
{
    public class EpisodeService : BaseService<EpisodeEntity, EpisodeRequest, EpisodeResponse>, IEpisodeService
    {
        private readonly IRepositoryWrapper _repository;
        public EpisodeService(IRepositoryWrapper repository, IBaseRepository<EpisodeEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }
    }
}
