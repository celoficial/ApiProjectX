using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Requests;
using ApiProjectX.Domain.Responses.Author;

namespace ApiProjectX.Domain.Interfaces.Services
{
    public interface IAuthorService : IBaseService<AuthorEntity, AuthorRequest, AuthorResponse>
    {
    }
}
