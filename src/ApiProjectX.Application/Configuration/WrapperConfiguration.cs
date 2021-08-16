using ApiProjectX.Domain.Interfaces.Repository;
using ApiProjectX.Infra.Data.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiProjectX.Application.Configuration
{
    public static class WrapperConfiguration
    {
        public static void ConfigureWrapper(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
