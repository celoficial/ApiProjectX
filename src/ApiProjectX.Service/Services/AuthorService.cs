using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using AutoMapper;

namespace ApiProjectX.Service.Services
{
    public class AuthorService : BaseService<AuthorEntity>, IAuthorService
    {
        private readonly IRepositoryWrapper _repository;

        public AuthorService(IRepositoryWrapper repository, IBaseRepository<AuthorEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }
    }
}
