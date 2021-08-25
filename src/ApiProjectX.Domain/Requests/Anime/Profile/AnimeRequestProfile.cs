using ApiProjectX.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Requests.Anime
{
   public class AnimeRequestProfile : Profile
    {
        public AnimeRequestProfile()
        {
            CreateMap<AnimeRequest, AnimeEntity>();
        }
    }
}
