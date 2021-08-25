using ApiProjectX.Domain.Responses.Anime;
using ApiProjectX.Domain.Responses.User;
using System;

namespace ApiProjectX.Domain.Responses.WatchLater
{
    public class WatchLaterResponse
    {
        public Guid Id { get; set; }
        public AnimeResponse Anime { get; set; }
        public UserResponse User { get; set; }
    }
}
