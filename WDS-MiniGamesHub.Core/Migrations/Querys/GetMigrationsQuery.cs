using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace WDS_MiniGamesHub.Core.Migrations.Querys
{
    public class GetMigrationsQuery : IRequest<IEnumerable<string>>
    {
    }
}
