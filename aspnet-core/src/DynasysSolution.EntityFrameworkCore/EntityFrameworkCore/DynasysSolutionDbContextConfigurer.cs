using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DynasysSolution.EntityFrameworkCore
{
    public static class DynasysSolutionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DynasysSolutionDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DynasysSolutionDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}