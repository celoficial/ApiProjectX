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
    public class AnimeCategoryEntityConfiguration : IEntityTypeConfiguration<AnimeCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<AnimeCategoryEntity> builder)
        {
            builder.HasKey(c => new { c.AnimeId, c.CategoryId });
        }
    }
}
