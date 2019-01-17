using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WDS_MiniGamesHub.Persistence.Mssql;

namespace WDS_MiniGamesHub.Core.Migrations.Querys
{
    public class GetMigrationsQueryHandler : IRequestHandler<GetMigrationsQuery, IEnumerable<string>>
    {
        private readonly WDSMiniGamesHubDbContext _context;

        public GetMigrationsQueryHandler(WDSMiniGamesHubDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<string>> Handle(GetMigrationsQuery request, CancellationToken cancellationToken)
        {
            return _context.GetPendingMigrationsAsync();
        }
    }
}
