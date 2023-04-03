using Microsoft.AspNetCore;
using MVCExampleEmployeeApp;

WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>()
        .Build()
        .Run();