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
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<UserModel>> GetUser()
        {
            return Ok(await Mediator.Send(new GetUserQuery()));
        }
    }
}