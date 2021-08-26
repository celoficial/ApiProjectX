using ApiProjectX.Domain.Enums;
using System;

namespace ApiProjectX.Domain.Responses.Watch
{
    public class WatchResponse
    {
        public Guid Id { get; set; }
        public Guid? AnimeId { get; set; }
        public Guid? UserId { get; set; }
        public WatchControlEnum WatchControl { get; set; }
    }
}
