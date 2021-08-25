using ApiProjectX.Domain.Entities;
using AutoMapper;

namespace ApiProjectX.Domain.Requests.Author
{
    public class AuthorRequestProfile : Profile
    {
        public AuthorRequestProfile()
        {
            CreateMap<AuthorRequest, AuthorEntity>();
        }
    }
}
