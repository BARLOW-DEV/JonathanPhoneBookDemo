namespace Acme.PhoneBookDemo.Authorization.Delegation
{
    public interface IUserDelegationConfiguration
    {
        bool IsEnabled { get; set; }
    }
}