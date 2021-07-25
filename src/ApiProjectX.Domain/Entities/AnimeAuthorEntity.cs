using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Entities
{
    public class AnimeAuthorEntity : BaseEntity
    {
        public Guid AuthorId { get; set; }
        public AuthorEntity Author { get; set; }

        public Guid AnimeId { get; set; }
        public AnimeEntity Anime { get; set; }
    }
}
