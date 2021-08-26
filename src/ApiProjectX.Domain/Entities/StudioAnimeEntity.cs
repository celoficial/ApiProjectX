using System;

namespace ApiProjectX.Domain.Entities
{
    public class StudioAnimeEntity : BaseEntity
    {
        public Guid? StudioId { get; set; }
        public Guid? AnimeId { get; set; }

        public StudioEntity Studio { get; set; }
        public AnimeEntity Anime { get; set; }
    }
}
