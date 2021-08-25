using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Requests.Studio
{
    public class StudioRequestProfile : Profile
    {
        public StudioRequestProfile()
        {
            CreateMap<StudioRequest, StudioEntity>();
        }
    }
}
