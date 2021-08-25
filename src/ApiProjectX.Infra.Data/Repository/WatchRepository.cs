using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    public class WatchRepository : BaseRepository<WatchEntity>, IWatchRepository
    {
        public WatchRepository(ProjectXContext dbContext) : base(dbContext)
        {
        }
    }
}
