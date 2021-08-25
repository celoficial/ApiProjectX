using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Requests.Watch;
using ApiProjectX.Domain.Responses.Watch;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IWatchService : IBaseService<WatchEntity, WatchRequest, WatchResponse>
    {
    }
}
