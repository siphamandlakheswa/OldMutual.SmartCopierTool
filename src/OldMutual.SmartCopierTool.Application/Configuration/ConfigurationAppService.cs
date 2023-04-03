using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OldMutual.SmartCopierTool.Configuration.Dto;

namespace OldMutual.SmartCopierTool.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SmartCopierToolAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
