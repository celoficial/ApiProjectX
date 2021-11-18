namespace ApiProjectX.Domain.Requests.Anime

{
    public class AnimeRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double? Rating { get; set; }
        public string ImgUrl { get; set; }
        public string Tags { get; set; }
    }
}
