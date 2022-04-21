using System.Threading.Tasks;
using Acme.PhoneBookDemo.Authorization.Users;

namespace Acme.PhoneBookDemo.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
