﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OldMutual.SmartCopierTool.Configuration;

namespace OldMutual.SmartCopierTool.Web.Host.Startup
{
    [DependsOn(
       typeof(SmartCopierToolWebCoreModule))]
    public class SmartCopierToolWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SmartCopierToolWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SmartCopierToolWebHostModule).GetAssembly());
        }
    }
}
