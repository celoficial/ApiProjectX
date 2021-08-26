using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Requests.Category;
using ApiProjectX.Domain.Responses.Category;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface ICategoryService : IBaseService<CategoryEntity, CategoryRequest, CategoryResponse>
    {
    }
}
