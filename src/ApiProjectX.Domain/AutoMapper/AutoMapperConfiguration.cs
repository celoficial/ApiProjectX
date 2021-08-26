using ApiProjectX.Domain.Requests.Anime;
using ApiProjectX.Domain.Requests.Author;
using ApiProjectX.Domain.Requests.Category;
using ApiProjectX.Domain.Requests.Episode;
using ApiProjectX.Domain.Requests.Season;
using ApiProjectX.Domain.Requests.Studio;
using ApiProjectX.Domain.Requests.User;
using ApiProjectX.Domain.Requests.Watch;
using ApiProjectX.Domain.Responses.Anime;
using ApiProjectX.Domain.Responses.Author;
using ApiProjectX.Domain.Responses.Category;
using ApiProjectX.Domain.Responses.Episode;
using ApiProjectX.Domain.Responses.Season;
using ApiProjectX.Domain.Responses.Studio;
using ApiProjectX.Domain.Responses.User;
using ApiProjectX.Domain.Responses.Watch;
using AutoMapper;

namespace ApiProjectX.Domain.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void RegisterMappings()
        {
            new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AnimeResponseProfile>();
                cfg.AddProfile<AnimeRequestProfile>();
                cfg.AddProfile<UserResponseProfile>();
                cfg.AddProfile<UserRequestProfile>();
                cfg.AddProfile<WatchRequestProfile>();
                cfg.AddProfile<WatchResponseProfile>();
                cfg.AddProfile<AuthorResponseProfile>();
                cfg.AddProfile<AuthorRequestProfile>();
                cfg.AddProfile<StudioResponseProfile>();
                cfg.AddProfile<StudioRequestProfile>();
                cfg.AddProfile<SeasonRequestProfile>();
                cfg.AddProfile<SeasonResponseProfile>();
                cfg.AddProfile<EpisodeResponseProfile>();
                cfg.AddProfile<EpisodeRequestProfile>();
                cfg.AddProfile<CategoryRequestProfile>();
                cfg.AddProfile<CategoryResponseProfile>();
            });
        }
    }
}
