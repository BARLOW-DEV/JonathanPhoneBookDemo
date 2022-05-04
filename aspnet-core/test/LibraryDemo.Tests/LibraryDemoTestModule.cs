using Abp.Modules;
using LibraryDemo.Test.Base;

namespace LibraryDemo.Tests
{
    [DependsOn(typeof(LibraryDemoTestBaseModule))]
    public class LibraryDemoTestModule : AbpModule
    {
       
    }
}
