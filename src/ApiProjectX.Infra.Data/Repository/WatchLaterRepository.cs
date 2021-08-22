using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    public class WatchLaterRepository : BaseRepository<WatchLaterEntity>, IWatchLaterRepository
    {
        public WatchLaterRepository(ProjectXContext dbContext) : base(dbContext)
        {

        } 
    }
}
