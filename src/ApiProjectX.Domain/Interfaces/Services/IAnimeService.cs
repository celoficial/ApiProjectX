using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Requests;
using ApiProjectX.Domain.Responses;
using ApiProjectX.Domain.Responses.Anime;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IAnimeService : IBaseService<AnimeEntity, AnimeRequest, AnimeResponse>
    {
        Task<GenericResult> GetAllResponse();
    }
}
