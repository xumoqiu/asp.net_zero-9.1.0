using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using DynasysSolution.Configure;
using DynasysSolution.Startup;
using DynasysSolution.Test.Base;

namespace DynasysSolution.GraphQL.Tests
{
    [DependsOn(
        typeof(DynasysSolutionGraphQLModule),
        typeof(DynasysSolutionTestBaseModule))]
    public class DynasysSolutionGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DynasysSolutionGraphQLTestModule).GetAssembly());
        }
    }
}