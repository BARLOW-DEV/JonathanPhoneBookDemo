using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryDemo.Authorization;

namespace LibraryDemo
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(LibraryDemoApplicationSharedModule),
        typeof(LibraryDemoCoreModule)
        )]
    public class LibraryDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryDemoApplicationModule).GetAssembly());
        }
    }
}