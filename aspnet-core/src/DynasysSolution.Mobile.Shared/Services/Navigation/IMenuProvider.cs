using System.Collections.Generic;
using MvvmHelpers;
using DynasysSolution.Models.NavigationMenu;

namespace DynasysSolution.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}