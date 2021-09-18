using Autofac;
using Jayride.CodeChallenge.Interfaces.Services;
using Jayride.CodeChallenge.Services;

namespace Jayride.CodeChallenge.DependenciesRegistration
{
    public class ServicesModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CandidateService>().As<ICandidateService>().InstancePerRequest();
        }
    }
}
