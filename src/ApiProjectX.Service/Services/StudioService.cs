using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.Studio;
using ApiProjectX.Domain.Responses;
using ApiProjectX.Domain.Responses.Studio;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public class StudioService : BaseService<StudioEntity, StudioRequest, StudioResponse>, IStudioService
    {
        private readonly IRepositoryWrapper _repository;
        public StudioService(IRepositoryWrapper repository, IBaseRepository<StudioEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }

        public async Task<GenericResult> GetAllResponse()
        {
            var entities = await _repository.Studio.FindAll();

            var entities2 = _mapper.Map<IEnumerable<StudioEntity>, IEnumerable<StudioAllResponse>>(entities);

            return new GenericResult("deu certo", true, entities2);
        }
    }
}
