using Abp.AspNetCore.Mvc.Views;

namespace LibraryDemo.Web.Views
{
    public abstract class LibraryDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected LibraryDemoRazorPage()
        {
            LocalizationSourceName = LibraryDemoConsts.LocalizationSourceName;
        }
    }
}
