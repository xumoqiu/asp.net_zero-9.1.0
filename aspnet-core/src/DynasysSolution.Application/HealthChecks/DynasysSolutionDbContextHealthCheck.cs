using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using DynasysSolution.EntityFrameworkCore;

namespace DynasysSolution.HealthChecks
{
    public class DynasysSolutionDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public DynasysSolutionDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("DynasysSolutionDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("DynasysSolutionDbContext could not connect to database"));
        }
    }
}
