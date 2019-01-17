using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WDS_MiniGamesHub.Persistence.Mssql;

namespace WDS_MiniGamesHub.Core.Migrations.Commands
{
    public class MigrateCommand : IRequest
    {

        public class Handler : IRequestHandler<MigrateCommand, Unit>
        {
            private readonly WDSMiniGamesHubDbContext _context;

            public Handler(WDSMiniGamesHubDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(MigrateCommand request, CancellationToken cancellationToken)
            {
                await _context.MigrateAsync();

                return Unit.Value;
            }
        }
    }
}
