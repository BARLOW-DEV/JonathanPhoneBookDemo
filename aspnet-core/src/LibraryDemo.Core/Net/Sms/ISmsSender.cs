using System.Threading.Tasks;

namespace LibraryDemo.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}