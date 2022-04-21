using Abp.Modules;
using Acme.PhoneBookDemo.Test.Base;

namespace Acme.PhoneBookDemo.Tests
{
    [DependsOn(typeof(PhoneBookDemoTestBaseModule))]
    public class PhoneBookDemoTestModule : AbpModule
    {
       
    }
}
