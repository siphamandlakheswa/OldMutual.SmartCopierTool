using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OldMutual.SmartCopierTool.Configuration;
using OldMutual.SmartCopierTool.EntityFrameworkCore;
using OldMutual.SmartCopierTool.Migrator.DependencyInjection;

namespace OldMutual.SmartCopierTool.Migrator
{
    [DependsOn(typeof(SmartCopierToolEntityFrameworkModule))]
    public class SmartCopierToolMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SmartCopierToolMigratorModule(SmartCopierToolEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SmartCopierToolMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SmartCopierToolConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SmartCopierToolMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
