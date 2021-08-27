using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Responses.Category
{
    public class CategoryResponseProfile : Profile
    {
        public CategoryResponseProfile()
        {
            CreateMap<CategoryEntity, CategoryAllReponse>();
            //implementar dps
            CreateMap<CategoryEntity, CategoryResponse>();
        }
    }
}