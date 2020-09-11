using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using DynasysSolution.Configuration;

namespace DynasysSolution.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(DynasysSolutionTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
