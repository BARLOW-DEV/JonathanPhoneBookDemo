using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Acme.PhoneBookDemo.Authorization;

namespace Acme.PhoneBookDemo
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(PhoneBookDemoApplicationSharedModule),
        typeof(PhoneBookDemoCoreModule)
        )]
    public class PhoneBookDemoApplicationModule : AbpModule
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
            IocManager.RegisterAssemblyByConvention(typeof(PhoneBookDemoApplicationModule).GetAssembly());
        }
    }
}