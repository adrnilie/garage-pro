using System.Drawing;
using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;

namespace GaragePro.Services
{
    using Configuration;

    public class DependenciesResolver
    {
        private static IContainer container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        private static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Register you Web API controllers
            builder.RegisterType<ConfigurationSettings>().As<IConfigurationSettings>();

            // Set the dependency to Autofac
            container = builder.Build();

            return container;
        }
    }
}