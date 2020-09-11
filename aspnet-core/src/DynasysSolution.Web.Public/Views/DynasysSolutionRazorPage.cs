using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace DynasysSolution.Web.Public.Views
{
    public abstract class DynasysSolutionRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected DynasysSolutionRazorPage()
        {
            LocalizationSourceName = DynasysSolutionConsts.LocalizationSourceName;
        }
    }
}
