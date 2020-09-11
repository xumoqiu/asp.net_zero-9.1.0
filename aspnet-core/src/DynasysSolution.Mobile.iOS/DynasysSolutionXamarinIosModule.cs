using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DynasysSolution
{
    [DependsOn(typeof(DynasysSolutionXamarinSharedModule))]
    public class DynasysSolutionXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DynasysSolutionXamarinIosModule).GetAssembly());
        }
    }
}