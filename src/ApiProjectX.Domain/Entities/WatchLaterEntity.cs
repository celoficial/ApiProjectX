using System;

namespace ApiProjectX.Domain.Entities
{
    public class WatchLaterEntity : BaseEntity
    {
        public Guid? AnimeId { get; set; }
        public AnimeEntity Anime { get; set; }

        public Guid? UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
