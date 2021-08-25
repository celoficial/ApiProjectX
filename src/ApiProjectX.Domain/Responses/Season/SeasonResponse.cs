using ApiProjectX.Domain.Responses.Anime;
using System;
using System.Collections.Generic;

namespace ApiProjectX.Domain.Responses.Season
{
    public class SeasonResponse
    {
        public Guid Id { get; set; }
        public Guid? AnimeId { get; set; }
        public AnimeResponse Anime { get; set; }
        public ICollection<EpisodeResponse> Episode { get; set; }
    }
}
