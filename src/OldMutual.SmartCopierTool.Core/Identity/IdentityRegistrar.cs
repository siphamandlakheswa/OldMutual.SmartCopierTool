using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using OldMutual.SmartCopierTool.Authorization;
using OldMutual.SmartCopierTool.Authorization.Roles;
using OldMutual.SmartCopierTool.Authorization.Users;
using OldMutual.SmartCopierTool.Editions;
using OldMutual.SmartCopierTool.MultiTenancy;

namespace OldMutual.SmartCopierTool.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
