using System.Threading.Tasks;
using Abp.Webhooks;

namespace Acme.PhoneBookDemo.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
