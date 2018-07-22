using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using GPDH.Evolution.Configuration;
using GPDH.Evolution.Web;

namespace GPDH.Evolution.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EvolutionDbContextFactory : IDesignTimeDbContextFactory<EvolutionDbContext>
    {
        public EvolutionDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EvolutionDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EvolutionDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EvolutionConsts.ConnectionStringName));

            return new EvolutionDbContext(builder.Options);
        }
    }
}
