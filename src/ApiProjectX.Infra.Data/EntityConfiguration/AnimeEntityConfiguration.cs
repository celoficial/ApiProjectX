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
            builder.Property(c => c.Description).HasMaxLength(255);
            builder.Property(c => c.Rating)
                .IsRequired(false)
                .HasMaxLength(5)// alterar depois
                .HasDefaultValue(0);
            builder.Property(c => c.ImgUrl).IsRequired(false);
           // builder.HasOne(c => c.Studio);



        }
    }
}
