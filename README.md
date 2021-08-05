# Janda.Runtime.Security

[![.NET](https://github.com/Jandini/Janda.Runtime.Security/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Jandini/Janda.Runtime.Security/actions/workflows/dotnet.yml)

Provides an easy way to check if application is running with administrative privileges. 



Following code will throw exception if administrator permissions are not available.


```C#
var identity = provider.GetRequiredService<IWindowsIdentityService>();
identity.RequireAdministrator();
```

