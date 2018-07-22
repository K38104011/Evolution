using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GPDH.Evolution.Authorization;

namespace GPDH.Evolution
{
    [DependsOn(
        typeof(EvolutionCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EvolutionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EvolutionAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EvolutionApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
