using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Requests.User;
using ApiProjectX.Domain.Responses.User;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IUserService : IBaseService<UserEntity, UserRequest, UserResponse>
    {
    }
}
