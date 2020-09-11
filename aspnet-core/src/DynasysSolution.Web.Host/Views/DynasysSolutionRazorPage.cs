using Abp.AspNetCore.Mvc.Views;

namespace DynasysSolution.Web.Views
{
    public abstract class DynasysSolutionRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected DynasysSolutionRazorPage()
        {
            LocalizationSourceName = DynasysSolutionConsts.LocalizationSourceName;
        }
    }
}
