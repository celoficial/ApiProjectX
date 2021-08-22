using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using AutoMapper;

namespace ApiProjectX.Service.Services
{
    public class CategoryService : BaseService<CategoryEntity>, ICategoryService
    {
        private readonly IRepositoryWrapper _repository;

        public CategoryService(IRepositoryWrapper repository, IBaseRepository<CategoryEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }
    }
}
