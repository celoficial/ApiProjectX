using ApiProjectX.Domain.Entities;
using ApiProjectX.Infra.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ApiProjectX.Infra.Data.Context
{
    public class ProjectXContext : DbContext
    {
        public ProjectXContext(DbContextOptions<ProjectXContext> options): base(options){}

        public ProjectXContext(){}

        //definir dbSet
        public DbSet<AnimeEntity> Anime { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.SetNull;
            }

            modelBuilder.Entity<AnimeEntity>(new AnimeEntityConfiguration().Configure);
        }
    }
}
