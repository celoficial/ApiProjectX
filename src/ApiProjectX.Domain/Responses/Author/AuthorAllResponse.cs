using ApiProjectX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Responses.Author
{
   public class AuthorAllResponse
    {
        public Guid Id { get; set; }
        public string AuthorName { get; set; }
        public ICollection<AnimeAuthorEntity> AnimeAuthor { get; set; }
    }
}
