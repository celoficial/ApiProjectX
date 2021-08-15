using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ProjectXContext _dbContext;
        private IAnimeRepository _anime;

        public RepositoryWrapper(ProjectXContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IAnimeRepository Anime
        {
            get
            {
                if (_anime == null)
                {
                    _anime = new AnimeRepository(_dbContext);
                }

                return _anime;
            }
        }
    }
}
