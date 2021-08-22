using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Responses.Anime
{
    public class AnimeProfile : Profile
    {
        public AnimeProfile()
        {
            CreateMap<AnimeAllResponse, AnimeEntity>()
                .ForMember(a => a.AnimeAuthor, opt => opt.Ignore())
                .ForMember(a => a.AnimeCategory, opt => opt.Ignore());
            CreateMap<AnimeEntity, AnimeAllResponse>();
        }
    }
}
