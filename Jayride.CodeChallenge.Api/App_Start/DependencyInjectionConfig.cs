using Autofac;
using Autofac.Integration.WebApi;
using Jayride.CodeChallenge.DependenciesRegistration;
using System.Reflection;
using System.Web.Http;

namespace Jayride.CodeChallenge.Api
{
    public static class DependencyInjectionConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new RepositoriesModule());
            builder.RegisterModule(new ServicesModule());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}