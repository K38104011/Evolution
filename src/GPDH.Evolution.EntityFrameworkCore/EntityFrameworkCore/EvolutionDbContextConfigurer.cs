using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GPDH.Evolution.EntityFrameworkCore
{
    public static class EvolutionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EvolutionDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EvolutionDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
