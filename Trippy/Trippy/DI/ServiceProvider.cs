using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Trippy.DI
{
    internal class ServiceProvider
    {
        private readonly IServiceCollection services;

        public ServiceProvider(IServiceCollection services)
        {
            this.services = services;
        }

        public IServiceProvider Initialize()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(services);

            var modules = GetModules();

            foreach (var module in modules)
            {
                containerBuilder.RegisterModule(module);
            }

            var container = containerBuilder.Build();
            return new AutofacServiceProvider(container);
        }

        private IEnumerable<IModule> GetModules()
        {
            return DependencyContext.Default.GetDefaultAssemblyNames()
                .Select(Assembly.Load)
                .SelectMany(t => t.GetTypes())
                .Where(p => p.IsSubclassOf<Autofac.Module>() && p.HasParameterlessConstructor())
                .Select(Activator.CreateInstance)
                .Cast<IModule>();
        }
    }
}
