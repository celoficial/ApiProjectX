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
    public class StudioAnimeEntityConfiguration : IEntityTypeConfiguration<StudioAnimeEntity>
    {
        public void Configure(EntityTypeBuilder<StudioAnimeEntity> builder)
        {
            builder.HasKey(c => c.Id);

        }
    }
}
