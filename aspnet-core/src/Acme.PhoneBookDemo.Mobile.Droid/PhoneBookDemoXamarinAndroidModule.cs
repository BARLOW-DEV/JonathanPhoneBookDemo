using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Acme.PhoneBookDemo
{
    [DependsOn(typeof(PhoneBookDemoXamarinSharedModule))]
    public class PhoneBookDemoXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookDemoXamarinAndroidModule).GetAssembly());
        }
    }
}