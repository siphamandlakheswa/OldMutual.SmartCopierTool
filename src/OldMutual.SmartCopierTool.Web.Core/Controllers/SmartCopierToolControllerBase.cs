using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OldMutual.SmartCopierTool.Controllers
{
    public abstract class SmartCopierToolControllerBase: AbpController
    {
        protected SmartCopierToolControllerBase()
        {
            LocalizationSourceName = SmartCopierToolConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
