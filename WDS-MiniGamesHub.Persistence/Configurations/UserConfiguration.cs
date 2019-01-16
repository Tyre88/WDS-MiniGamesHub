using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WDS_MiniGamesHub.Domain.Entities;

namespace WDS_MiniGamesHub.Persistence.Mysql.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Id).UseMySqlIdentityColumn();
            builder.Property(e => e.Email).HasMaxLength(500);
        }
    }
}
