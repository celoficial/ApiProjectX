using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Entities
{
    public class CategoryEntity : BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<AnimeCategoryEntity> AnimeCategories { get; set; }
    }
}
