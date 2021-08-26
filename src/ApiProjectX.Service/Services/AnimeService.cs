using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests;
using ApiProjectX.Domain.Responses;
using ApiProjectX.Domain.Responses.Anime;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public class AnimeService : BaseService<AnimeEntity, AnimeRequest, AnimeResponse>, IAnimeService
    {
        private readonly IRepositoryWrapper _repository;
        public AnimeService(IRepositoryWrapper repository, IBaseRepository<AnimeEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }

        public async Task<GenericResult> GetAllResponse()
        {
            var entities = await _repository.Anime.FindAll();

            var entities2 = _mapper.Map<IEnumerable<AnimeEntity>, IEnumerable<AnimeAllResponse>>(entities);

            return new GenericResult("deu certo", true, entities2);

        }
    }
}
