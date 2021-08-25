using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests;
using ApiProjectX.Domain.Responses;
using ApiProjectX.Domain.Responses.Author;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public class AuthorService : BaseService<AuthorEntity, AuthorRequest, AuthorResponse>, IAuthorService
    {
        private readonly IRepositoryWrapper _repository;

        public AuthorService(IRepositoryWrapper repository, IBaseRepository<AuthorEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }

        public async Task<GenericResult> GetAllResponse()
        {
            var entities = await _repository.Author.FindAll();

            var entities2 = _mapper.Map<IEnumerable<AuthorEntity>, IEnumerable<AuthorAllResponse>>(entities);

            return new GenericResult("deu certo", true, entities2);
        }
    }
}
