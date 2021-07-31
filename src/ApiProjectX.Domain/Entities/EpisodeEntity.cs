using System;

namespace ApiProjectX.Domain.Entities
{
    public class EpisodeEntity : BaseEntity
    {
       
        public string DescriptionEpisode { get; set; }

        public string ImgEpisodeUrl { get; set; }

        public Guid? SeasonId { get; set; }
        public SeasonEntity Season { get; set; }

    }
}
