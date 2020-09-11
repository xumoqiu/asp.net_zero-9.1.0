using Microsoft.Extensions.DependencyInjection;
using DynasysSolution.HealthChecks;

namespace DynasysSolution.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<DynasysSolutionDbContextHealthCheck>("Database Connection");
            builder.AddCheck<DynasysSolutionDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
