using Microsoft.Extensions.Logging;

namespace Janda.Runtime.Security
{
    internal class WindowsIdentityService : IWindowsIdentityService
    {
        public bool IsAdministrator => WindowsIdentityPrincipal.IsInAdministratorRole();

        public void RequireAdministrator()
        {
            if (!IsAdministrator)
                throw new AdministratorRequiredException();
        }
    }
}
