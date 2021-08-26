using ApiProjectX.Domain.Entities;
using System;

namespace ApiProjectX.Domain.Requests.Episode
{
    public class EpisodeRequest
    {
        public Guid Id { get; set; }
        public string EpisodeTitle { get; set; }
        public string ImgEpisodeUrl { get; set; }
        public SeasonEntity Season { get; set; }
    }
}
