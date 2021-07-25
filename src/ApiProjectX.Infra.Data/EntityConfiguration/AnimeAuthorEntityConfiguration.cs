using ApiProjectX.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProjectX.Infra.Data.EntityConfiguration
{
    public class AnimeAuthorEntityConfiguration : IEntityTypeConfiguration<AnimeAuthorEntity>
    {
        public void Configure(EntityTypeBuilder<AnimeAuthorEntity> builder)
        {
            builder.HasKey(c => new { c.AnimeId, c.AuthorId });
        }
    }
}
