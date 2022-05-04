using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LibraryDemo
{
    [DependsOn(typeof(LibraryDemoXamarinSharedModule))]
    public class LibraryDemoXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryDemoXamarinAndroidModule).GetAssembly());
        }
    }
}