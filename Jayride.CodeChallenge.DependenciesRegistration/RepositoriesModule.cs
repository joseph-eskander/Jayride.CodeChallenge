using Autofac;
using Jayride.CodeChallenge.Interfaces.Repositories;
using Jayride.CodeChallenge.Repositories;

namespace Jayride.CodeChallenge.DependenciesRegistration
{
    public class RepositoriesModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CandidateRepository>().As<ICandidateRepository>().InstancePerRequest();
        }
    }
}
