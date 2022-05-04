using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using LibraryDemo.Configure;
using LibraryDemo.Startup;
using LibraryDemo.Test.Base;

namespace LibraryDemo.GraphQL.Tests
{
    [DependsOn(
        typeof(LibraryDemoGraphQLModule),
        typeof(LibraryDemoTestBaseModule))]
    public class LibraryDemoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryDemoGraphQLTestModule).GetAssembly());
        }
    }
}