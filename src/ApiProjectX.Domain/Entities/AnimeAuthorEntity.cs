using System;

namespace ApiProjectX.Domain.Entities
{
    public class AnimeAuthorEntity : BaseEntity
    {
        public Guid? AuthorId { get; set; }
        public AuthorEntity Author { get; set; }

        public Guid? AnimeId { get; set; }
        public AnimeEntity Anime { get; set; }
    }
}
