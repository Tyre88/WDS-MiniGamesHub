using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

        public Task<IEnumerable<string>> GetPendingMigrationsAsync()
        {
            return Database.GetPendingMigrationsAsync();
        }

        public Task MigrateAsync()
        {
            return Database.MigrateAsync();
        }

        public DbSet<User> Users { get; set; }
    }
}
