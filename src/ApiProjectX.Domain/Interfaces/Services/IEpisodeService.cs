using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Requests.Episode;
using ApiProjectX.Domain.Responses.Episode;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IEpisodeService : IBaseService<EpisodeEntity, EpisodeRequest, EpisodeResponse>
    {
    }
}
