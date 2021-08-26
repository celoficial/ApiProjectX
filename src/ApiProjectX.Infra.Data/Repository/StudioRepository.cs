using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    public class StudioRepository : BaseRepository<StudioEntity>, IStudioRepository
    {
        public StudioRepository(ProjectXContext dbContext) : base(dbContext)
        {

        }
    }
}
