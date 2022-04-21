using Microsoft.Extensions.Configuration;

namespace Acme.PhoneBookDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
