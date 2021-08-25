using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Responses.Anime;
using ApiProjectX.Domain.Responses.User;
using AutoMapper;

namespace ApiProjectX.Domain.Responses.WatchLater
{
    public class WatchLaterResponseProfile : Profile
    {
        public WatchLaterResponseProfile()
        {
            CreateMap<WatchLaterEntity, WatchLaterAllResponse>()
                .ForSourceMember(a => a.Anime, opt => opt.DoNotValidate())
                .ForSourceMember(a => a.User, opt => opt.DoNotValidate());
            CreateMap<WatchLaterEntity, WatchLaterResponse>();
            CreateMap<AnimeResponse, WatchLaterResponse>();
            CreateMap<UserResponse, WatchLaterResponse>();
        }
    }
}
