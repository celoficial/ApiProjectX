using System;

namespace ApiProjectX.Domain.Responses.Anime
{
    public class AnimeAllResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double? Rating { get; set; }
        public string ImgUrl { get; set; }
    }
}
