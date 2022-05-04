using System.Threading.Tasks;
using Abp.Webhooks;

namespace LibraryDemo.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
