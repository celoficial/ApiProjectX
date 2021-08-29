using System.Collections.Generic;

namespace ApiProjectX.Domain.Entities
{
    public class StudioEntity : BaseEntity
    {
        public string StudioName { get; set; }

        public ICollection<StudioAnimeEntity> AnimeStudio { get; set; }
    }
}
