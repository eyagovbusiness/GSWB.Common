
namespace Common.Infrastructure.Security
{
    public static class DefaultTokenLifetimes
    {
        public static readonly TimeSpan AccessToken = TimeSpan.FromMinutes(5);
        public static readonly TimeSpan RefreshToken = TimeSpan.FromDays(2);
    }
}
