using System.Threading.Tasks;

namespace Acme.PhoneBookDemo.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}