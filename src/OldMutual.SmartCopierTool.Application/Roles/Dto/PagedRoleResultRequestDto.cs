using Abp.Application.Services.Dto;

namespace OldMutual.SmartCopierTool.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

