using Abp.AspNetCore.Mvc.ViewComponents;

namespace LibraryDemo.Web.Public.Views
{
    public abstract class LibraryDemoViewComponent : AbpViewComponent
    {
        protected LibraryDemoViewComponent()
        {
            LocalizationSourceName = LibraryDemoConsts.LocalizationSourceName;
        }
    }
}