namespace Acme.PhoneBookDemo.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}