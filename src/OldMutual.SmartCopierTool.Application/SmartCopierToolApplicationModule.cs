using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OldMutual.SmartCopierTool.Authorization;

namespace OldMutual.SmartCopierTool
{
    [DependsOn(
        typeof(SmartCopierToolCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SmartCopierToolApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SmartCopierToolAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SmartCopierToolApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
