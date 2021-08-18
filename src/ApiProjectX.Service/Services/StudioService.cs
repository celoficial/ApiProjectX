using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;

namespace ApiProjectX.Service.Services
{
    public class StudioService : BaseService<StudioEntity>, IStudioService
    {
        private readonly IRepositoryWrapper _repository;
        public StudioService(IRepositoryWrapper repository, IBaseRepository<StudioEntity> baseRepository): base(baseRepository)
        {
            _repository = repository;
        }
    }
}
