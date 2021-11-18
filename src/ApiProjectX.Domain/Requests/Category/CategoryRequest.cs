using ApiProjectX.Domain.Entities;
using System.Collections.Generic;


namespace ApiProjectX.Domain.Requests.Category
{
    public class CategoryRequest
    {
        public string CategoryName { get; set; }
        public ICollection<AnimeCategoryEntity> AnimeCategories { get; set; }
    }
}
