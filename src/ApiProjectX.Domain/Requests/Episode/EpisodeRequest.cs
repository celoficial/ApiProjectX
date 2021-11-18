using ApiProjectX.Domain.Entities;

namespace ApiProjectX.Domain.Requests.Episode
{
    public class EpisodeRequest
    {
        public string EpisodeTitle { get; set; }
        public string ImgEpisodeUrl { get; set; }
        public SeasonEntity Season { get; set; }
    }
}
