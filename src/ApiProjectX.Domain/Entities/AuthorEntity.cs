using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Entities
{
    public class AuthorEntity : BaseEntity
    {
        public string AuthorName { get; set; }
        public ICollection<AnimeAuthorEntity> AnimeAuthor { get; set; } 
    }
}
