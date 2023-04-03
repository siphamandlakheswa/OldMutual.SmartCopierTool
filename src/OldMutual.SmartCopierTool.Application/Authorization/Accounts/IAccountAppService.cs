using System.Threading.Tasks;
using Abp.Application.Services;
using OldMutual.SmartCopierTool.Authorization.Accounts.Dto;

namespace OldMutual.SmartCopierTool.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
