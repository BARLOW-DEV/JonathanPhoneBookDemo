using Abp.AspNetCore.Mvc.Views;

namespace Acme.PhoneBookDemo.Web.Views
{
    public abstract class PhoneBookDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected PhoneBookDemoRazorPage()
        {
            LocalizationSourceName = PhoneBookDemoConsts.LocalizationSourceName;
        }
    }
}
