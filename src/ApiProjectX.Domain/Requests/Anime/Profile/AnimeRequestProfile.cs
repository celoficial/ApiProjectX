using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Requests.Anime
{
   public class AnimeRequestProfile : Profile
    {
        public AnimeRequestProfile()
        {
            CreateMap<AnimeRequest, AnimeEntity>();
        }
    }
}
