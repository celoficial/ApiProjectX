using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Requests.Season
{
    public class SeasonRequestProfile : Profile
    {
        public SeasonRequestProfile()
        {
            CreateMap<SeasonRequest, SeasonEntity>();
        }
    }
}
