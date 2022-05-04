using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LibraryDemo
{
    [DependsOn(typeof(LibraryDemoXamarinSharedModule))]
    public class LibraryDemoXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryDemoXamarinIosModule).GetAssembly());
        }
    }
}