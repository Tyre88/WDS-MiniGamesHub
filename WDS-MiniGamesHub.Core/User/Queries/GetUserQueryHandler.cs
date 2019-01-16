using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WDS_MiniGamesHub.Core.User.Models;

namespace WDS_MiniGamesHub.Core.User.Queries
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserModel>
    {
        public async Task<UserModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return new UserModel
            {
                Id = request.Id,
                Email = "victor@gradera.nu",
                FirstName = "Victor",
                LastName = "Öhrström",
                UserName = request.UserName ?? "victor"
            };
        }
    }
}
