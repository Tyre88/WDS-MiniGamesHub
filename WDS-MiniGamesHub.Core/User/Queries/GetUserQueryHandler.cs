using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WDS_MiniGamesHub.Core.User.Models;
using WDS_MiniGamesHub.Persistence;

namespace WDS_MiniGamesHub.Core.User.Queries
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserModel>
    {
        private readonly WDSMiniGamesHubDbContext _context;

        public GetUserQueryHandler(WDSMiniGamesHubDbContext context)
        {
            _context = context;
        }

        public async Task<UserModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            Domain.Entities.User entity = null;
            if (request.Id > 0)
            {
                entity = await _context.Users.FindAsync(request.Id);
            }
            else if(!string.IsNullOrEmpty(request.UserName))
            {
                entity = await _context.Users.FindAsync(request.UserName);
            }


            if (entity == null)
            {
                throw new Exception();
            }

            return new UserModel
            {
                Id = entity.Id,
                Email = entity.Email,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                UserName = entity.UserName
            };
        }
    }
}
