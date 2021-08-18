using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    public class SeasonRepository : BaseRepository<SeasonEntity>, ISeasonRepository
    {
        public SeasonRepository(ProjectXContext dbContext) : base(dbContext)
        {

        }
    }
}
