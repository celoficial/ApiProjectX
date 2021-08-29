using ApiProjectX.Domain.Entities;
using AutoMapper;
using System.Linq;

namespace ApiProjectX.Domain.Responses.Anime
{
    public class AnimeResponseProfile : Profile
    {
        public AnimeResponseProfile()
        {
            CreateMap<AnimeEntity, AnimeAllResponse>()
                .ForMember(c => c.Categories, d => d.MapFrom(e => e.AnimeCategory.Select(f => f.Category)))
                .ForMember(c => c.Authors, d => d.MapFrom(e => e.AnimeAuthor.Select(f => f.Author)))
                .ForMember(c => c.Studios, d => d.MapFrom(e => e.AnimeStudio.Select(f => f.Studio)));
            CreateMap<AnimeEntity, AnimeResponse>();

        }
    }
}
