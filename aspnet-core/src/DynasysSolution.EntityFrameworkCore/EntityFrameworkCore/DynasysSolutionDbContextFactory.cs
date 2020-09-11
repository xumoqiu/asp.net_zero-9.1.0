using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DynasysSolution.Configuration;
using DynasysSolution.Web;

namespace DynasysSolution.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DynasysSolutionDbContextFactory : IDesignTimeDbContextFactory<DynasysSolutionDbContext>
    {
        public DynasysSolutionDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DynasysSolutionDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            DynasysSolutionDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DynasysSolutionConsts.ConnectionStringName));

            return new DynasysSolutionDbContext(builder.Options);
        }
    }
}