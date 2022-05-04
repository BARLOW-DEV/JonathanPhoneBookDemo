using Abp.Domain.Services;

namespace LibraryDemo
{
    public abstract class LibraryDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected LibraryDemoDomainServiceBase()
        {
            LocalizationSourceName = LibraryDemoConsts.LocalizationSourceName;
        }
    }
}
