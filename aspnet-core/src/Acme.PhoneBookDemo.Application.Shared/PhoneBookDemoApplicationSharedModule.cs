using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Acme.PhoneBookDemo
{
    [DependsOn(typeof(PhoneBookDemoCoreSharedModule))]
    public class PhoneBookDemoApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookDemoApplicationSharedModule).GetAssembly());
        }
    }
}