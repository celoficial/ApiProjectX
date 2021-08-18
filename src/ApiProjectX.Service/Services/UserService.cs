using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;

namespace ApiProjectX.Service.Services
{
    class UserService : BaseService<UserEntity>, IUserService
    {
        private readonly IRepositoryWrapper _repository;
        public UserService(IRepositoryWrapper repository, IBaseRepository<UserEntity> baseRepository) : base(baseRepository)
        {
            _repository = repository;
        }
    }
}
