using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    public class AuthorRepository : BaseRepository<AuthorEntity>, IAuthorRepository
    {
        public AuthorRepository(ProjectXContext dbContext) : base(dbContext)
        {
                
        }


    }
}
