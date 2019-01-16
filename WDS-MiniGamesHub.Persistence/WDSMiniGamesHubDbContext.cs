using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WDS_MiniGamesHub.Core.Entities;

namespace WDS_MiniGamesHub.Persistence
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
