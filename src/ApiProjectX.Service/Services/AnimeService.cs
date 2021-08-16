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
        private readonly IBaseRepository<AnimeEntity> _baseRepository;
        public AnimeService(IRepositoryWrapper repository, IBaseRepository<AnimeEntity> baseRepository):base(baseRepository)
        {
            _baseRepository = baseRepository;
            _repository = repository;
        }
    }
}
