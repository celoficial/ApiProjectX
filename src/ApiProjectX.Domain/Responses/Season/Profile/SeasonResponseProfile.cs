using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Responses.Season
{
    public class SeasonResponseProfile : Profile
    {
        public SeasonResponseProfile()
        {
            CreateMap<SeasonEntity, SeasonResponse>()
                .ForSourceMember(a => a.Anime, opt => opt.DoNotValidate());
        }
    }
}
