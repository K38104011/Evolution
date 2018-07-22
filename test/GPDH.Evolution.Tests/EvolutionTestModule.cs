using System;
using Castle.MicroKernel.Registration;
using NSubstitute;
using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Modules;
using Abp.Configuration.Startup;
using Abp.Net.Mail;
using Abp.TestBase;
using Abp.Zero.Configuration;
using Abp.Zero.EntityFrameworkCore;
using GPDH.Evolution.EntityFrameworkCore;
using GPDH.Evolution.Tests.DependencyInjection;
using GPDH.Evolution.Tests.TestDatas;

namespace GPDH.Evolution.Tests
{
    [DependsOn(
        typeof(EvolutionApplicationModule),
        typeof(EvolutionEntityFrameworkModule),
        typeof(AbpTestBaseModule)
        )]
    public class EvolutionTestModule : AbpModule
    {
        public EvolutionTestModule(EvolutionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;
        }

        public override void PreInitialize()
        {
            Configuration.UnitOfWork.Timeout = TimeSpan.FromMinutes(30);
            Configuration.UnitOfWork.IsTransactional = false;

            // Disable static mapper usage since it breaks unit tests (see https://github.com/aspnetboilerplate/aspnetboilerplate/issues/2052)
            Configuration.Modules.AbpAutoMapper().UseStaticMapper = false;

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            // Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            RegisterFakeService<AbpZeroDbMigrator<EvolutionDbContext>>();

            Configuration.ReplaceService<IEmailSender, NullEmailSender>(DependencyLifeStyle.Transient);
        }

        public override void Initialize()
        {
            ServiceCollectionRegistrar.Register(IocManager);
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        private void RegisterFakeService<TService>() where TService : class
        {
            IocManager.IocContainer.Register(
                Component.For<TService>()
                    .UsingFactoryMethod(() => Substitute.For<TService>())
                    .LifestyleSingleton()
            );
        }

        protected virtual void UsingDbContext(Action<EvolutionDbContext> action)
        {
            using (var context = IocManager.Resolve<EvolutionDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }
    }
}
