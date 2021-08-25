using System;

namespace ApiProjectX.Domain.Requests.WatchLater
{
    public class WatchLaterRequest
    {
        public Guid Id { get; set; }
        public Guid? AnimeId { get; set; }
        public Guid? UserId { get; set; }
    }
}
