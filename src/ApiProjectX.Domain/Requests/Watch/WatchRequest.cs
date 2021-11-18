using ApiProjectX.Domain.Enums;
using System;

namespace ApiProjectX.Domain.Requests.Watch
{
    public class WatchRequest
    {
        public Guid? AnimeId { get; set; }
        public Guid? UserId { get; set; }
        public WatchControlEnum WatchControl { get; set; }
    }
}
