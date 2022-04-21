using Xamarin.Forms.Internals;

namespace Acme.PhoneBookDemo.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}