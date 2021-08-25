using ApiProjectX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProjectX.Infra.Data.EntityConfiguration
{
    public class WatchEntityConfiguration : IEntityTypeConfiguration<WatchEntity>
    {
        public void Configure(EntityTypeBuilder<WatchEntity> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.AnimeId).IsRequired(false);
            builder.Property(c => c.UserId).IsRequired(false);
            builder.Property(c => c.WatchControl).IsRequired(true);
        }
    }
}
