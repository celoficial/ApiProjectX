using ApiProjectX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProjectX.Infra.Data.EntityConfiguration
{
    public class EpisodeEntityConfiguration : IEntityTypeConfiguration<EpisodeEntity>
    {
        public void Configure(EntityTypeBuilder<EpisodeEntity> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.DescriptionEpisode).HasMaxLength(255);

            builder.Property(c => c.ImgEpisodeUrl).IsRequired(false);

            builder.Property(c => c.SeasonId).IsRequired(false);

        }
    }
}