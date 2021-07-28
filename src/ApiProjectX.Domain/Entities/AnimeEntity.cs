using System.Collections.Generic;

namespace ApiProjectX.Domain.Entities
{
    public class AnimeEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double? Rating { get; set; }
        public string ImgUrl { get; set; }

        public ICollection<AnimeCategoryEntity> AnimeCategory { get; set; }
        public ICollection<AnimeAuthorEntity> AnimeAuthor { get; set; }

    }
}
