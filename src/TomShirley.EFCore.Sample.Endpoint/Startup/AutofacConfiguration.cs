using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Serilog;

namespace TomShirley.EFCore.Sample.Endpoint.Startup
{
    public class AutofacConfiguration
    {
        public static ContainerBuilder Configure(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(Log.Logger).AsImplementedInterfaces();

            var endpointAssembly = Assembly.Load("TomShirley.EFCore.Sample.Endpoint"); ;
            builder
                .RegisterInterfacesInNamespace(endpointAssembly, "Services")
                .RegisterInterfacesInNamespace(endpointAssembly, "Validators");
            
            builder.RegisterModule<EndpointModule>();

            builder.Populate(serviceCollection);

            return builder;
        }
    }

    internal static class AutofacExtensions
    {
        public static ContainerBuilder RegisterInterfacesInNamespace(this ContainerBuilder builder, Assembly assembly, string namespacePartial)
        {
            assembly.GetTypes()
                .Where(x => x.IsClass && !x.IsAbstract)
                .Where(x => !x.Name.ToLower().Contains("anonymous"))
                .Where(x => x.Namespace != null && x.Namespace.EndsWith(namespacePartial))
                .ToList()
                .ForEach(x => builder.RegisterType(x).AsImplementedInterfaces());

            return builder;
        }
    }
}
