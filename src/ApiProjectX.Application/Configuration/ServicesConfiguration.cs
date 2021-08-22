using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Service.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiProjectX.Application.Configuration
{
    public static class ServicesConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<IAnimeService, AnimeService>();
            services.AddTransient<IAuthorService, AuthorService>();
            services.AddTransient<ISeasonService, SeasonService>();
            services.AddTransient<IStudioService, StudioService>();
            services.AddTransient<IEpisodeService, EpisodeService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IWatchLaterService, WatchLaterService>();
        }
    }
}
