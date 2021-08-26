using ApiProjectX.Domain.Entities;
using System;
using System.Collections.Generic;


namespace ApiProjectX.Domain.Requests.Category
{
    public class CategoryRequest
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<AnimeCategoryEntity> AnimeCategories { get; set; }
    }
}
