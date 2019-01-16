using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WDS_MiniGamesHub.Domain.Entities;

namespace WDS_MiniGamesHub.Persistence.Mssql
{
    public class WDSMiniGamesHubDbContext : DbContext
    {
        public WDSMiniGamesHubDbContext(DbContextOptions<WDSMiniGamesHubDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
