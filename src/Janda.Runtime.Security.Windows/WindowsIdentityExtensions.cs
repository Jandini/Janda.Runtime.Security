using Microsoft.Extensions.DependencyInjection;

namespace Janda.Runtime.Security
{
    public static class WindowsIdentityExtensions
    {
        public static IServiceCollection AddWindowsIdentityService(this IServiceCollection services)
        {
            return services.AddTransient<IWindowsIdentityService, WindowsIdentityService>();
        }
    }
}
