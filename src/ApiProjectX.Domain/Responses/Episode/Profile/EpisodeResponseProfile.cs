using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Responses.Episode
{
    public class EpisodeResponseProfile : Profile
    {
        public EpisodeResponseProfile()
        {
            CreateMap<EpisodeEntity, EpisodeAllResponse>();
            CreateMap<EpisodeEntity, EpisodeResponse>();
        }
    }
}
