using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using LibraryDemo.EntityFrameworkCore;

namespace LibraryDemo.HealthChecks
{
    public class LibraryDemoDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public LibraryDemoDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("LibraryDemoDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("LibraryDemoDbContext could not connect to database"));
        }
    }
}
