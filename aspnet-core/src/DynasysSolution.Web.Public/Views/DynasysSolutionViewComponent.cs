using Abp.AspNetCore.Mvc.ViewComponents;

namespace DynasysSolution.Web.Public.Views
{
    public abstract class DynasysSolutionViewComponent : AbpViewComponent
    {
        protected DynasysSolutionViewComponent()
        {
            LocalizationSourceName = DynasysSolutionConsts.LocalizationSourceName;
        }
    }
}