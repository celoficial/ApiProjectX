using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Requests.Category
{
    public class CategoryRequestProfile : Profile
    {
        public CategoryRequestProfile()
        {
            CreateMap<CategoryRequest, CategoryEntity>();
        }
    }
}