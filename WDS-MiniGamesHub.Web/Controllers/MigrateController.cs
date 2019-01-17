using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WDS_MiniGamesHub.Core.Migrations.Commands;
using WDS_MiniGamesHub.Core.Migrations.Querys;
using WDS_MiniGamesHub.Persistence.Mssql;

namespace WDS_MiniGamesHub.Web.Controllers
{
    [ApiController]
    public class MigrateController : BaseController
    {
        [Route("api/migrate/migrate")]
        public async Task<ActionResult<bool>> IsDatabaseCreated()
        {
            return Ok(await Mediator.Send(new MigrateCommand()));
        }

        [Route("api/migrate/getmigrations")]
        public async Task<ActionResult<IEnumerable<string>>> GetMigrations()
        {
            return Ok(await Mediator.Send(new GetMigrationsQuery()));
        }
    }
}