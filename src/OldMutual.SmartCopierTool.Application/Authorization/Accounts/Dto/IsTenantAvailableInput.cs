using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace OldMutual.SmartCopierTool.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}
