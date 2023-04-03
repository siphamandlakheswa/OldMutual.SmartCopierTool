using Abp.Authorization;
using OldMutual.SmartCopierTool.Authorization.Roles;
using OldMutual.SmartCopierTool.Authorization.Users;

namespace OldMutual.SmartCopierTool.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
