namespace ApiProjectX.Domain.Entities
{
    public class AnimeEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Gen { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public string ImgUrl { get; set; }
        public string AuthorUrl { get; set; }
    }
}
