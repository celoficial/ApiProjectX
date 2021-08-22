using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Responses;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IAnimeService : IBaseService<AnimeEntity>
    {
        Task<GenericResult> GetAllResponse();
    }
}
