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
    public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
       

        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.UserName).HasMaxLength(255).IsRequired();
            builder.Property(c => c.UserEmail).HasMaxLength(255).IsRequired();
            builder.Property(c => c.UserBirth).HasMaxLength(8).IsRequired();
            builder.Property(c => c.UserNick).HasMaxLength(20).IsRequired();
            builder.Property(c => c.UserPassword).HasMaxLength(20).IsRequired();
            builder.HasIndex(c => c.UserNick).IsUnique();
            builder.HasIndex(c => c.UserEmail).IsUnique();
          
             
        }
    }
}
