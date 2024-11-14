using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Common.Infrastructure.DataAccess.DbContext
{
    public class DataProtectionKeysDbContext(DbContextOptions<DataProtectionKeysDbContext> options) : Microsoft.EntityFrameworkCore.DbContext(options), IDataProtectionKeyContext
    {
        public DbSet<DataProtectionKey> DataProtectionKeys { get; set; }
    }
}
