using System.Threading.Tasks;
using DynasysSolution.Authorization.Users;

namespace DynasysSolution.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
