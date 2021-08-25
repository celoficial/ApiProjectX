using ApiProjectX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Responses.Anime
{
    public class AnimeResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double? Rating { get; set; }
        public string ImgUrl { get; set; }
        public string Tags { get; set; }
        public ICollection<AnimeCategoryEntity> AnimeCategory { get; set; }
        public ICollection<AnimeAuthorEntity> AnimeAuthor { get; set; }
    }
}
