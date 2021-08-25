using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Requests.WatchLater
{
    public class WatchLaterRequestProfile : Profile
    {
        public WatchLaterRequestProfile()
        {
            CreateMap<WatchLaterRequest, WatchLaterEntity>();
        }
    }
}
