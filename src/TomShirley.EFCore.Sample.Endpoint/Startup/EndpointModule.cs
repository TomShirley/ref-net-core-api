using Autofac;
using TomShirley.EFCore.Sample.Endpoint.Controllers;

namespace TomShirley.EFCore.Sample.Endpoint.Startup
{
    public class EndpointModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BlogsControllerImpl>().AsImplementedInterfaces();
        }
    }
}
