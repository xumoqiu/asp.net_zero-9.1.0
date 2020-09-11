using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DynasysSolution
{
    [DependsOn(typeof(DynasysSolutionXamarinSharedModule))]
    public class DynasysSolutionXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DynasysSolutionXamarinAndroidModule).GetAssembly());
        }
    }
}