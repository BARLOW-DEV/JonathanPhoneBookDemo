using Abp.Dependency;
using Acme.PhoneBookDemo.Configuration;
using Acme.PhoneBookDemo.Url;
using Acme.PhoneBookDemo.Web.Url;

namespace Acme.PhoneBookDemo.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor appConfigurationAccessor) :
            base(appConfigurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}