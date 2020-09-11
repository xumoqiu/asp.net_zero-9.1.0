using System.Threading.Tasks;
using Abp.Webhooks;

namespace DynasysSolution.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
