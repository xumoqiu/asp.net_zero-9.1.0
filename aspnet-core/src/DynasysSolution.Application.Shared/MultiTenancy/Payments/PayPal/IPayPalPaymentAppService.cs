using System.Threading.Tasks;
using Abp.Application.Services;
using DynasysSolution.MultiTenancy.Payments.PayPal.Dto;

namespace DynasysSolution.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
