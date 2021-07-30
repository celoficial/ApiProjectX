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
    public class SeasonEntityConfiguration : IEntityTypeConfiguration<SeasonEntity>
    {
        public void Configure(EntityTypeBuilder<SeasonEntity> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.AnimeId).IsRequired(false);
           
        }
    }
}