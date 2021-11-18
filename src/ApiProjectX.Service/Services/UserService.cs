using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.User;
using ApiProjectX.Domain.Responses;
using ApiProjectX.Domain.Responses.User;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public class UserService : BaseService<UserEntity, UserRequest, UserResponse>, IUserService
    {
        private readonly IRepositoryWrapper _repository;
        public UserService(IRepositoryWrapper repository, IBaseRepository<UserEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }

        public async Task<GenericResult> GetAllResponse()
        {
            var entities = await _repository.User.FindAll();

            var entities2 = _mapper.Map<IEnumerable<UserEntity>, IEnumerable<UserAllResponse>>(entities);

            return new GenericResult("deu certo", true, entities2);
        }
    }
}
