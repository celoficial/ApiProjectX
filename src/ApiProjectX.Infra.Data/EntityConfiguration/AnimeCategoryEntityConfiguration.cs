using ApiProjectX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProjectX.Infra.Data.EntityConfiguration
{
    public class AnimeCategoryEntityConfiguration : IEntityTypeConfiguration<AnimeCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<AnimeCategoryEntity> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.AnimeId).IsRequired(false);
            builder.Property(c => c.CategoryId).IsRequired(false);
            builder.HasOne(c => c.Anime).WithMany(c => c.AnimeCategory).HasForeignKey(c => c.AnimeId);
            builder.HasOne(c => c.Category).WithMany(c => c.AnimeCategories).HasForeignKey(c => c.CategoryId);
        }
    }
}
