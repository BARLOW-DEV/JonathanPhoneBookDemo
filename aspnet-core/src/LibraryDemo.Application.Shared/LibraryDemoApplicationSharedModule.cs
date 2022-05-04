using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LibraryDemo
{
    [DependsOn(typeof(LibraryDemoCoreSharedModule))]
    public class LibraryDemoApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryDemoApplicationSharedModule).GetAssembly());
        }
    }
}