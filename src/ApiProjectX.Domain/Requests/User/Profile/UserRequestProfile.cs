using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Requests.User
{
    public class UserRequestProfile : Profile
    {
        public UserRequestProfile()
        {
            CreateMap<UserRequest, UserEntity>();
        }
    }
}
