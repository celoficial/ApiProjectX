using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;

namespace ApiProjectX.Service.Services
{
    public class AuthorService : BaseService<AuthorEntity>, IAuthorService
    {
        private readonly IRepositoryWrapper _repository;

        public AuthorService(IRepositoryWrapper repository, IBaseRepository<AuthorEntity> baseRepository) : base(baseRepository)
        {
            _repository = repository;
        }
    }
}
