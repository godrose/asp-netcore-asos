using Microsoft.Extensions.DependencyInjection;
using LogoFX.Server.Bootstrapping;

namespace Nova.AlgoLab.Facade
{
    internal sealed class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper(IServiceCollection dependencyRegistrator) : base(dependencyRegistrator)
        {
        }

        public override string[] Prefixes => new[]
        {
            "Nova.AlgoLab.Facade"
        };
    }
}
