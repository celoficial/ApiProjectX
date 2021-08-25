using ApiProjectX.Domain.Requests.Anime;
using ApiProjectX.Domain.Responses.Anime;
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
            });
        }
    }
}
