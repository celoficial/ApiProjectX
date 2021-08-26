using ApiProjectX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProjectX.Infra.Data.EntityConfiguration
{
    public class AnimeAuthorEntityConfiguration : IEntityTypeConfiguration<AnimeAuthorEntity>
    {
        public void Configure(EntityTypeBuilder<AnimeAuthorEntity> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.AnimeId).IsRequired(false);
            builder.Property(c => c.AuthorId).IsRequired(false);
        }
    }
}
