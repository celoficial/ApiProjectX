using ApiProjectX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProjectX.Infra.Data.EntityConfiguration
{
    public class StudioEntityConfiguration : IEntityTypeConfiguration<StudioEntity>
    {
        public void Configure(EntityTypeBuilder<StudioEntity> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.StudioName).HasMaxLength(255);
        }
    }
}
