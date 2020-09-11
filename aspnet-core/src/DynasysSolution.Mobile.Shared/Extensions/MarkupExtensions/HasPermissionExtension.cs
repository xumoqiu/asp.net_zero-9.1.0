using System;
using DynasysSolution.Core;
using DynasysSolution.Core.Dependency;
using DynasysSolution.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynasysSolution.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}