namespace ApiProjectX.Domain.Interfaces.Repository
{
    public interface IRepositoryWrapper
    {
        IAnimeRepository Anime { get; }
        IAuthorRepository Author { get; }
        IUserRepository User { get; }
    }
}
