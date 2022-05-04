using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LibraryDemo
{
    public class LibraryDemoCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryDemoCoreSharedModule).GetAssembly());
        }
    }
}