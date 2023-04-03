using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OldMutual.SmartCopierTool.EntityFrameworkCore;
using OldMutual.SmartCopierTool.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace OldMutual.SmartCopierTool.Web.Tests
{
    [DependsOn(
        typeof(SmartCopierToolWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SmartCopierToolWebTestModule : AbpModule
    {
        public SmartCopierToolWebTestModule(SmartCopierToolEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SmartCopierToolWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SmartCopierToolWebMvcModule).Assembly);
        }
    }
}