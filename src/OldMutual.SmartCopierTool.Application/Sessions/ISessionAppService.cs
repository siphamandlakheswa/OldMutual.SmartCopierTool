using System.Threading.Tasks;
using Abp.Application.Services;
using OldMutual.SmartCopierTool.Sessions.Dto;

namespace OldMutual.SmartCopierTool.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
