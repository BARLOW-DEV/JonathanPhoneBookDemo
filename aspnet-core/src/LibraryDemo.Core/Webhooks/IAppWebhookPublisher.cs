using System.Threading.Tasks;
using LibraryDemo.Authorization.Users;

namespace LibraryDemo.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
