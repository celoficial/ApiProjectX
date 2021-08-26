using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
   public class EpisodeRepository : BaseRepository<EpisodeEntity>, IEpisodeRepository
    {
        public EpisodeRepository(ProjectXContext dbContext) : base(dbContext)
        {

        }
    }
}
