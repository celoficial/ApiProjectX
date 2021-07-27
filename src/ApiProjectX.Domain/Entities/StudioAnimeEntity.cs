using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Entities
{
    public class StudioAnimeEntity : BaseEntity
    {
        public Guid StudioId { get; set; }
        public Guid AnimeId { get; set; }

        public StudioEntity Studio { get; set; }
        public AnimeEntity Anime { get; set; }
    }
}
