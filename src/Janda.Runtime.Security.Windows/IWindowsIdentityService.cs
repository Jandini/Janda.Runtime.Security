namespace Janda.Runtime.Security
{
    public interface IWindowsIdentityService
    {
        bool IsAdministrator { get; }
        void RequireAdministrator();        
    }
}
