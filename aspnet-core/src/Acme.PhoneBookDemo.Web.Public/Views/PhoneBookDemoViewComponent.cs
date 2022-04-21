using Abp.AspNetCore.Mvc.ViewComponents;

namespace Acme.PhoneBookDemo.Web.Public.Views
{
    public abstract class PhoneBookDemoViewComponent : AbpViewComponent
    {
        protected PhoneBookDemoViewComponent()
        {
            LocalizationSourceName = PhoneBookDemoConsts.LocalizationSourceName;
        }
    }
}