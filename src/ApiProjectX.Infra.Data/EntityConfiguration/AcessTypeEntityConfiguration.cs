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
    class AcessTypeEntityConfiguration : IEntityTypeConfiguration<AcessTypeEntity>
    {
        public void Configure(EntityTypeBuilder<AcessTypeEntity> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Type).IsRequired();
        }
    }
}
