using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;

namespace ApiProjectX.Service.Services
{
    public class CategoryService : BaseService<CategoryEntity>, ICategoryService
    {
        private readonly IRepositoryWrapper _repository;

        public CategoryService(IRepositoryWrapper repository, IBaseRepository<CategoryEntity> baseRepository) : base(baseRepository)
        {
            _repository = repository;
        }
    }
}
