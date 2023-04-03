using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OldMutual.SmartCopierTool.EntityFrameworkCore
{
    public static class SmartCopierToolDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SmartCopierToolDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SmartCopierToolDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
