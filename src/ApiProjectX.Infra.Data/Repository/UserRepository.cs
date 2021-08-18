using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Context;

namespace ApiProjectX.Infra.Data.Repository
{
    class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(ProjectXContext dbContext) : base(dbContext)
        {

        }
    }
}
