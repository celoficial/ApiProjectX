using ApiProjectX.Domain.Responses.Anime;
using AutoMapper;

namespace ApiProjectX.Application.Configuration
{
    public class AutoMapperConfiguration
    {
        public static void RegisterMappings()
        {
            new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AnimeProfile>();
            });
        }
    }
}
