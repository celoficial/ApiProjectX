using ApiProjectX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProjectX.Infra.Data.EntityConfiguration
{
    public class StudioAnimeEntityConfiguration : IEntityTypeConfiguration<StudioAnimeEntity>
    {
        public void Configure(EntityTypeBuilder<StudioAnimeEntity> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.AnimeId).IsRequired(false);
            builder.Property(c => c.StudioId).IsRequired(false);
        }
    }
}
