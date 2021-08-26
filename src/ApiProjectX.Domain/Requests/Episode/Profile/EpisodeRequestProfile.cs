using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Requests.Episode
{
    public class EpisodeRequestProfile : Profile
    {
        public EpisodeRequestProfile()
        {
            CreateMap<EpisodeRequest, EpisodeEntity>();
        }
    }
}
