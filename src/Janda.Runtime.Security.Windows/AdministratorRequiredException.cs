using System;

namespace Janda.Runtime.Security
{
    public class AdministratorRequiredException : Exception
    {
        public override string Message => "Administrator privileges required";
    }
}
