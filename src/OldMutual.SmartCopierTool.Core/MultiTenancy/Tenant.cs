using Abp.MultiTenancy;
using OldMutual.SmartCopierTool.Authorization.Users;

namespace OldMutual.SmartCopierTool.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
