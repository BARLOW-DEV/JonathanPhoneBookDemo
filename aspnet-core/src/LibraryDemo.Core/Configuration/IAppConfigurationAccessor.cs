using Microsoft.Extensions.Configuration;

namespace LibraryDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
