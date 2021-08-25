using System;

namespace ApiProjectX.Domain.Requests.Season
{
    public class SeasonRequest
    {
        public Guid Id { get; set; }
        public Guid? AnimeId { get; set; }
    }
}
