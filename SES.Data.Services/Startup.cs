using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace SES.Data.Services
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection serviceCollection)
        {
            // Services
            Assembly assembly = Assembly.Load("SES.Data.Services");
            assembly
                .GetTypes()
                .Where(e => e.IsClass)
                .Where(e => (e.Namespace ?? "").Equals("SES.Data.Services"))
                .Where(e => e.BaseType.Name.StartsWith("DataServiceBase"))
                .ToList()
                .ForEach(classType =>
                {
                    Type interfaceType = assembly.GetType($"{classType.Namespace}.Interfaces.I{classType.Name}");
                    serviceCollection.AddTransient(interfaceType, classType);
                });

            // Repositories
            assembly = Assembly.Load("SES.Data.Services");
            assembly
                .GetTypes()
                .Where(e => e.IsClass)
                .Where(e => (e.Namespace ?? "").Equals("SES.Data.Services.Repositories"))
                .Where(e => e.BaseType.Name.StartsWith("RepositoryBase"))
                .ToList()
                .ForEach(classType =>
                {
                    Type interfaceType = assembly.GetType($"{classType.Namespace}.Interfaces.I{classType.Name}");
                    serviceCollection.AddTransient(interfaceType, classType);
                });

        }
    }
}
