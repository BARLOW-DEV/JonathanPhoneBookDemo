using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Acme.PhoneBookDemo
{
    public class PhoneBookDemoCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookDemoCoreSharedModule).GetAssembly());
        }
    }
}