using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    class WatchingRepository : BaseRepository<WatchingEntity>, IWatchingRepository
    {
        public WatchingRepository(ProjectXContext dbContext) : base(dbContext)
        {
        }
    }
}
