using Microsoft.Extensions.Configuration;

namespace DynasysSolution.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
