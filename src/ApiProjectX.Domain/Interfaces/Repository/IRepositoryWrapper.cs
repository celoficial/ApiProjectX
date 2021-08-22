namespace ApiProjectX.Domain.Interfaces.Repository
{
    public interface IRepositoryWrapper
    {
        IAnimeRepository Anime { get; }
        IAuthorRepository Author { get; }
        IUserRepository User { get; }
        IStudioRepository Studio { get; }
        IEpisodeRepository Episode { get; }
        ICategoryRepository Category { get; }
    }
}
