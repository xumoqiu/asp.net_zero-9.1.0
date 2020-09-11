using System.Threading.Tasks;
using Abp.Application.Services;
using DynasysSolution.MultiTenancy.Payments.Dto;
using DynasysSolution.MultiTenancy.Payments.Stripe.Dto;

namespace DynasysSolution.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}