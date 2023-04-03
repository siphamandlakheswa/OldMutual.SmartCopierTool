using System.Collections.Generic;

namespace OldMutual.SmartCopierTool.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
