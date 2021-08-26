using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.Category;
using ApiProjectX.Domain.Responses;
using ApiProjectX.Domain.Responses.Category;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Service.Services
{
    public class CategoryService : BaseService<CategoryEntity, CategoryRequest, CategoryResponse>, ICategoryService
    {
        private readonly IRepositoryWrapper _repository;

        public CategoryService(IRepositoryWrapper repository, IBaseRepository<CategoryEntity> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _repository = repository;
        }

        public async Task<GenericResult> GetAllResponse()
        {
            var entities = await _repository.Category.FindAll();
            var entities2 = _mapper.Map<IEnumerable<CategoryEntity>, IEnumerable<CategoryAllReponse>>(entities);
            return new GenericResult("deu bom", true, entities2);
        }
    }
}
