using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WDS_MiniGamesHub.Core.User.Models;
using WDS_MiniGamesHub.Core.User.Queries;

namespace WDS_MiniGamesHub.Web.Controllers
{
    [ApiController]
    public class UserController : BaseController
    {
        [HttpGet]
        [Route("api/user/getuser/{id:int?}")]
        public async Task<ActionResult<UserModel>> GetUser(int id = -1)
        {
            return Ok(await Mediator.Send(new GetUserQuery() { Id = id }));
        }

        [HttpGet]
        [Route("api/user/getuser/{userName}")]
        public async Task<ActionResult<UserModel>> GetUser(string userName)
        {
            return Ok(await Mediator.Send(new GetUserQuery() { UserName = userName }));
        }
    }
}