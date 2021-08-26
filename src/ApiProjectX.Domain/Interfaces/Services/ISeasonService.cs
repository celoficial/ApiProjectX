using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Requests.Season;
using ApiProjectX.Domain.Responses.Season;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface ISeasonService : IBaseService<SeasonEntity, SeasonRequest, SeasonResponse>
    {
    }
}
