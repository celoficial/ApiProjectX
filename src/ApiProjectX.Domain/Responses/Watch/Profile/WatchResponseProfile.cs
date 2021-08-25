using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Responses.Watch
{
    public class WatchResponseProfile : Profile
    {
        public WatchResponseProfile()
        {
            CreateMap<WatchEntity, WatchResponse>()
                .ForSourceMember(a => a.Anime, opt => opt.DoNotValidate())
                .ForSourceMember(a => a.User, opt => opt.DoNotValidate());
        }
    }
}
