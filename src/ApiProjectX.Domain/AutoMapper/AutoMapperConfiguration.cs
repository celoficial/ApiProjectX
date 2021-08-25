﻿using ApiProjectX.Domain.Requests.Anime;
using ApiProjectX.Domain.Requests.User;
using ApiProjectX.Domain.Requests.WatchLater;
using ApiProjectX.Domain.Responses.Anime;
using ApiProjectX.Domain.Responses.User;
using ApiProjectX.Domain.Responses.WatchLater;
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
                cfg.AddProfile<WatchLaterRequestProfile>();
                cfg.AddProfile<WatchLaterResponseProfile>();
            });
        }
    }
}
