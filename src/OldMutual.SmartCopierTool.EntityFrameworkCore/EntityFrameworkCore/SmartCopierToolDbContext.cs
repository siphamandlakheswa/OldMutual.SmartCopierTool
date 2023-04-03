using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OldMutual.SmartCopierTool.Authorization.Roles;
using OldMutual.SmartCopierTool.Authorization.Users;
using OldMutual.SmartCopierTool.MultiTenancy;

namespace OldMutual.SmartCopierTool.EntityFrameworkCore
{
    public class SmartCopierToolDbContext : AbpZeroDbContext<Tenant, Role, User, SmartCopierToolDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SmartCopierToolDbContext(DbContextOptions<SmartCopierToolDbContext> options)
            : base(options)
        {
        }
    }
}
