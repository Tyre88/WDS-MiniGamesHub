using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WDS_MiniGamesHub.Domain.Entities;

namespace WDS_MiniGamesHub.Persistence.Mssql.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Id).UseSqlServerIdentityColumn();
            builder.Property(e => e.Email).HasMaxLength(500);
            builder.Property(e => e.Created).HasDefaultValue(DateTime.Now);
        }
    }
}
