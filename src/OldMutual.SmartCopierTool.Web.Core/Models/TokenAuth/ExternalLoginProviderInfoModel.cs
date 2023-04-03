using Abp.AutoMapper;
using OldMutual.SmartCopierTool.Authentication.External;

namespace OldMutual.SmartCopierTool.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
