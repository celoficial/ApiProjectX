using System;
using System.Collections.Generic;

namespace ApiProjectX.Domain.Entities
{
    public class SeasonEntity : BaseEntity
    {
        public Guid? AnimeId { get; set; }
        public AnimeEntity Anime { get; set; }
        public ICollection<EpisodeEntity> Episode { get; set; }
    }
}
