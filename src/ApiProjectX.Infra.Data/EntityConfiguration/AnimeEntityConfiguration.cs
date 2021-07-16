using ApiProjectX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProjectX.Infra.Data.EntityConfiguration
{
    public class AnimeEntityConfiguration : IEntityTypeConfiguration<AnimeEntity>
    {
        public void Configure(EntityTypeBuilder<AnimeEntity> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).HasMaxLength(255);
        }
    }
}
