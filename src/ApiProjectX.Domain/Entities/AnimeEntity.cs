using System;

namespace ApiProjectX.Domain.Entities
{
    public class AnimeEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public string ImgUrl { get; set; }

      //  public Guid StudioId { get; set; }
       // public StudioEntity Studio { get; set; }

    }
}
