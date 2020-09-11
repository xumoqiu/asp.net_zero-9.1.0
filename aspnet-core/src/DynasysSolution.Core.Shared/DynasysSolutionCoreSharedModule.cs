using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DynasysSolution
{
    public class DynasysSolutionCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DynasysSolutionCoreSharedModule).GetAssembly());
        }
    }
}