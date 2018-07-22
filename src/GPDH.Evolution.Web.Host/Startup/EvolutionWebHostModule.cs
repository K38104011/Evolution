using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GPDH.Evolution.Configuration;

namespace GPDH.Evolution.Web.Host.Startup
{
    [DependsOn(
       typeof(EvolutionWebCoreModule))]
    public class EvolutionWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EvolutionWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EvolutionWebHostModule).GetAssembly());
        }
    }
}
