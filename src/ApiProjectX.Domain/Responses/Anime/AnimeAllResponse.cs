using ApiProjectX.Domain.Responses.Author;
using ApiProjectX.Domain.Responses.Category;
using System;
using System.Collections.Generic;

namespace ApiProjectX.Domain.Responses.Anime
{
    public class AnimeAllResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double? Rating { get; set; }
        public string ImgUrl { get; set; }
        public IEnumerable<CategoryResponse> Categories { get; set; }
        public IEnumerable<AuthorResponse> Authors { get; set; }
    }
}
