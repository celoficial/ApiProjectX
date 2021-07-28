using ApiProjectX.Infra.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace ApiProjectX.Application.Configuration
{
    public static class DataBaseConfiguration
    {
        public static void ConfigureDataBase(this IServiceCollection services, IConfiguration config, IWebHostEnvironment env)
        {
            switch (env.EnvironmentName)
            {
                case "Local":
                    services.AddDbContext<ProjectXContext>(opts => opts.UseSqlServer(config["ConnectionStrings:DefaultConnection"]));
                    break;
                case "Development":
                    services.AddDbContext<ProjectXContext>(opts => opts.UseSqlServer(config["ConnectionStrings:DefaultConnection"]), ServiceLifetime.Transient);
                    break;
                case "Production":
                    services.AddDbContext<ProjectXContext>(opts => opts.UseSqlServer(config["ConnectionStrings:DefaultConnection"]), ServiceLifetime.Transient);
                    break;
                default:
                    services.AddDbContext<ProjectXContext>(opts => opts.UseSqlServer(config["ConnectionStrings:DefaultConnection"]), ServiceLifetime.Transient);
                    break;
            }
        }

        public static void InitializeDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var appDbContext = serviceScope.ServiceProvider.GetRequiredService<ProjectXContext>();

                if (appDbContext.Database.GetPendingMigrations().Any())
                {
                    appDbContext.Database.Migrate();
                }
            }
        }
    }
}
