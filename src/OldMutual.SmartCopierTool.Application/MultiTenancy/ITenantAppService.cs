using Abp.Application.Services;
using OldMutual.SmartCopierTool.MultiTenancy.Dto;

namespace OldMutual.SmartCopierTool.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

