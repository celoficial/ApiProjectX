using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ProjectXContext _dbContext;
        private IAnimeRepository _anime;
        private IAuthorRepository _author;

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

        public IAuthorRepository Author
        {
            get
            {
                if (_author == null)
                {
                    _author = new AuthorRepository(_dbContext);
                }
                return _author;
            }
        }
    }
}
