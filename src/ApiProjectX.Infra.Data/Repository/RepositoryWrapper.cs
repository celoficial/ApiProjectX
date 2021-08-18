using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ProjectXContext _dbContext;
        private IAnimeRepository _anime;
        private IAuthorRepository _author;
        private IUserRepository _user;
        private ISeasonRepository _season;

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

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_dbContext);
                }
                return _user;
            }
        }

        public ISeasonRepository Season
        {
            get
            {
                if(_season == null)
                {
                    _season = new SeasonRepository(_dbContext);
                }
                return _season;
            }
        }
    }
}
