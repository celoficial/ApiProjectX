using ApiProjectX.Domain.Enums;
using System;

namespace ApiProjectX.Domain.Entities
{
    public class WatchEntity : BaseEntity
    {
         public Guid? AnimeId { get; set; }
         public AnimeEntity Anime { get; set; }

         public Guid? UserId { get; set; }
         public UserEntity User { get; set; }
         public WatchControlEnum WatchControl { get; set; }
    }
}
