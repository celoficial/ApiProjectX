using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Entities
{
    public class AnimeCategoryEntity : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        public Guid AnimeId { get; set; }
        public AnimeEntity Anime { get; set; }

    }
}
