using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DynasysSolution.Startup
{
    [DependsOn(typeof(DynasysSolutionCoreModule))]
    public class DynasysSolutionGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DynasysSolutionGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}