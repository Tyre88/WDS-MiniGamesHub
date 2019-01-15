using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using WDS_MiniGamesHub.Core.User.Models;

namespace WDS_MiniGamesHub.Core.User.Queries
{
    public class GetUserQuery : IRequest<UserModel>
    {
        public int Id { get; set; }
    }
}
