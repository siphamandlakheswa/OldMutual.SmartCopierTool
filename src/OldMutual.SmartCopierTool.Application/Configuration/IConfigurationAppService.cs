using System.Threading.Tasks;
using OldMutual.SmartCopierTool.Configuration.Dto;

namespace OldMutual.SmartCopierTool.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
