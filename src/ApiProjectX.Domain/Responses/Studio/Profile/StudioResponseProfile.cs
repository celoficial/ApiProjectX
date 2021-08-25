using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Responses.Studio
{
    public class StudioResponseProfile : Profile
    {
        public StudioResponseProfile()
        {
            CreateMap<StudioEntity, StudioAllResponse>();
            CreateMap<StudioEntity, StudioResponse>();

        }
    }
}
