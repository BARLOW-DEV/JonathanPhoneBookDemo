using System.Collections.Generic;
using MvvmHelpers;
using LibraryDemo.Models.NavigationMenu;

namespace LibraryDemo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}