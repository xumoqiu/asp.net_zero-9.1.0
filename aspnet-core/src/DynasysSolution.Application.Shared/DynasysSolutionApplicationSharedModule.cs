using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DynasysSolution
{
    [DependsOn(typeof(DynasysSolutionCoreSharedModule))]
    public class DynasysSolutionApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DynasysSolutionApplicationSharedModule).GetAssembly());
        }
    }
}