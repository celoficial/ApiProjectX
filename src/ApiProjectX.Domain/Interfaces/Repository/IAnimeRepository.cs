using ApiProjectX.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Interfaces.Repository
{
    public interface IAnimeRepository : IBaseRepository<AnimeEntity>
    {
        Task<List<AnimeEntity>> testAnime();

    }
}
