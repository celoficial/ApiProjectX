using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    public class AnimeRepository : BaseRepository<AnimeEntity>, IAnimeRepository
    {
        public AnimeRepository(ProjectXContext dbContext) : base(dbContext)
        {

        }
    }
}
