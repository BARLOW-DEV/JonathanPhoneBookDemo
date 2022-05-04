using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LibraryDemo
{
    public class LibraryDemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryDemoClientModule).GetAssembly());
        }
    }
}
