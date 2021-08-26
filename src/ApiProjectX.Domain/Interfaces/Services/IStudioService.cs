using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Requests;
using ApiProjectX.Domain.Responses.Studio;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IStudioService : IBaseService<StudioEntity, StudioRequest, StudioResponse>
    {
    }
}
