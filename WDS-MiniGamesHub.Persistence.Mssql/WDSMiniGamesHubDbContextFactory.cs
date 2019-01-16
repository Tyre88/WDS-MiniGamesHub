using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WDS_MiniGamesHub.Persistence.Mssql.Infrastructure;

namespace WDS_MiniGamesHub.Persistence.Mssql
{
    public class WDSMiniGamesHubDbContextFactory : DesignTimeDbContextFactoryBase<WDSMiniGamesHubDbContext>
    {
        protected override WDSMiniGamesHubDbContext CreateNewInstance(DbContextOptions<WDSMiniGamesHubDbContext> options)
        {
            return new WDSMiniGamesHubDbContext(options);
        }
    }
}
