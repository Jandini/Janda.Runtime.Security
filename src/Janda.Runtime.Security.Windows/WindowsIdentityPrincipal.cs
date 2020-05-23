using System.Security.Principal;

namespace Janda.Runtime.Security
{
    public static class WindowsIdentityPrincipal
    {
        public static bool IsInAdministratorRole()
        {
            using var identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
