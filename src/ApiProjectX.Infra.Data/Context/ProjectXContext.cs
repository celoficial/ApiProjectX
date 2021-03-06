using ApiProjectX.Domain.Entities;
using ApiProjectX.Infra.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ApiProjectX.Infra.Data.Context
{
    public class ProjectXContext : DbContext
    {
        public ProjectXContext(DbContextOptions<ProjectXContext> options) : base(options) { }

        public ProjectXContext() { }

        public DbSet<AnimeEntity> Anime { get; set; }
        public DbSet<StudioEntity> Studio { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<AnimeCategoryEntity> AnimeCategory { get; set; }
        public DbSet<AuthorEntity> Author { get; set; }
        public DbSet<AnimeAuthorEntity> AnimeAuthor { get; set; }
        public DbSet<EpisodeEntity> Episode { get; set; }
        public DbSet<SeasonEntity> Season { get; set; }
        public DbSet<WatchEntity> Watch { get; set; }
        public DbSet<AcessTypeEntity> AcessType { get; set; }
        public DbSet<UserEntity> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.SetNull;
            }

            modelBuilder.Entity<AnimeEntity>(new AnimeEntityConfiguration().Configure);
            modelBuilder.Entity<StudioEntity>(new StudioEntityConfiguration().Configure);
            modelBuilder.Entity<EpisodeEntity>(new EpisodeEntityConfiguration().Configure);
            modelBuilder.Entity<SeasonEntity>(new SeasonEntityConfiguration().Configure);
            modelBuilder.Entity<WatchEntity>(new WatchEntityConfiguration().Configure);
            modelBuilder.Entity<StudioAnimeEntity>(new StudioAnimeEntityConfiguration().Configure);
            modelBuilder.Entity<CategoryEntity>(new CategoryEntityConfiguration().Configure);
            modelBuilder.Entity<AnimeCategoryEntity>(new AnimeCategoryEntityConfiguration().Configure);
            modelBuilder.Entity<AuthorEntity>(new AuthorEntityConfiguration().Configure);
            modelBuilder.Entity<AnimeAuthorEntity>(new AnimeAuthorEntityConfiguration().Configure);
            modelBuilder.Entity<AcessTypeEntity>(new AcessTypeEntityConfiguration().Configure);
            modelBuilder.Entity<UserEntity>(new UserEntityConfiguration().Configure);
        }
    }
}
