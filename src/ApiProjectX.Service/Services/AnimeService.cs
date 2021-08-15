using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public class AnimeService : BaseService<AnimeEntity>, IAnimeService
    {
        private readonly IRepositoryWrapper _repository;

        public AnimeService(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<AnimeEntity>> GetAll()
        {
            var result = _repository.Anime.FindAll();
            return result;
        }
    }
}
