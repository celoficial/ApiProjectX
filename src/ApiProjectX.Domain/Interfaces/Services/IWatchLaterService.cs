using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Requests.WatchLater;
using ApiProjectX.Domain.Responses.WatchLater;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IWatchLaterService : IBaseService<WatchLaterEntity, WatchLaterRequest, WatchLaterResponse>
    {
    }
}
