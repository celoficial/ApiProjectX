using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Requests
{
    public class AnimeRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double? Rating { get; set; }
        public string ImgUrl { get; set; }
        public string Tags { get; set; }
    }
}
