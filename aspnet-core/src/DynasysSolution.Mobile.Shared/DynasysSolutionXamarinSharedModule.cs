using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DynasysSolution
{
    [DependsOn(typeof(DynasysSolutionClientModule), typeof(AbpAutoMapperModule))]
    public class DynasysSolutionXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DynasysSolutionXamarinSharedModule).GetAssembly());
        }
    }
}