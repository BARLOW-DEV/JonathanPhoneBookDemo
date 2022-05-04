using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LibraryDemo.Startup
{
    [DependsOn(typeof(LibraryDemoCoreModule))]
    public class LibraryDemoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryDemoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}