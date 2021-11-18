using ApiProjectX.Domain.Entities;
using System.Collections.Generic;

namespace ApiProjectX.Domain.Requests.Author
{
   public class AuthorRequest
    {
        public string AuthorName { get; set; }
        public ICollection<AnimeAuthorEntity> AnimeAuthor { get; set; }
    }
}
