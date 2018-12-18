using System.Reflection;

namespace Nova.AlgoLab.Data.Contracts.Providers
{
    public static class AssemblyInfo
    {
        public static string AssemblyName { get; } = $"{Assembly.GetExecutingAssembly().GetName().Name}.dll";
    }
}
