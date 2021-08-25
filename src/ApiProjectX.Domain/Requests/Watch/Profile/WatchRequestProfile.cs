using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Requests.Watch
{
    public class WatchRequestProfile : Profile
    {
        public WatchRequestProfile()
        {
            CreateMap<WatchRequest, WatchEntity>();
        }
    }
}
