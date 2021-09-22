using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Modul2HW5.Services.Abstractions;
using Modul2HW5.Services;

namespace Modul2HW5
{
    public class Starter
    {
        public void StartApplication()
        {
            var serviceProvider = new ServiceCollection()
            .AddTransient<IActions, Actions>()
            .AddTransient<IFileService, FileService>()
            .AddSingleton<ILogger, Logger>()
            .AddTransient<Application>()
            .BuildServiceProvider();
            var appStarter = serviceProvider.GetService<Application>();
            appStarter.Run();
        }
    }
}
