using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Responses.Anime
{
    public class AnimeResponseProfile : Profile
    {
        public AnimeResponseProfile()
        {
            CreateMap<AnimeEntity, AnimeAllResponse>()
                .ForSourceMember(a => a.AnimeAuthor, opt => opt.DoNotValidate())
                .ForSourceMember(a => a.AnimeCategory, opt => opt.DoNotValidate());
            CreateMap<AnimeEntity, AnimeResponse>();

        }
    }
}
