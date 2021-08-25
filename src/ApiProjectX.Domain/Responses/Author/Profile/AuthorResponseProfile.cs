using ApiProjectX.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Domain.Responses.Author
{
   public class AuthorResponseProfile : Profile
    {
        public AuthorResponseProfile()
        {
            CreateMap<AuthorEntity, AuthorAllResponse>();
            CreateMap<AuthorEntity, AuthorResponse>();
        }
    }
}
