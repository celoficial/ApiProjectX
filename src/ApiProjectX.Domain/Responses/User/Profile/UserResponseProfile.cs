using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Responses.User
{
    public class UserResponseProfile : Profile
    {
        public UserResponseProfile()
        {
            CreateMap<UserEntity, UserAllResponse>()
                .ForSourceMember(a => a.AcessTypeId, opt => opt.DoNotValidate());
            CreateMap<UserEntity, UserResponse>();
        }
    }
}
