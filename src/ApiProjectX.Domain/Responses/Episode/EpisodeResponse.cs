using ApiProjectX.Domain.Entities;
using System;

namespace ApiProjectX.Domain.Responses.Episode
{
    public class EpisodeResponse
    {
        public Guid Id { get; set; }
        public string EpisodeTitle { get; set; }
        public string DescriptionEpisode { get; set; }
        public string ImgEpisodeUrl { get; set; }
        public SeasonEntity Season { get; set; }

    }
}
