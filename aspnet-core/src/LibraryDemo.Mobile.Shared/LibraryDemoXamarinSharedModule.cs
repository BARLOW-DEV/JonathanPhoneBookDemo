using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LibraryDemo
{
    [DependsOn(typeof(LibraryDemoClientModule), typeof(AbpAutoMapperModule))]
    public class LibraryDemoXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryDemoXamarinSharedModule).GetAssembly());
        }
    }
}