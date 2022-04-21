using System.Collections.Generic;
using MvvmHelpers;
using Acme.PhoneBookDemo.Models.NavigationMenu;

namespace Acme.PhoneBookDemo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}