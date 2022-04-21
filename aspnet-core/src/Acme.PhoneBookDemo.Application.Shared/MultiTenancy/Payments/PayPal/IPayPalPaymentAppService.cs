using System.Threading.Tasks;
using Abp.Application.Services;
using Acme.PhoneBookDemo.MultiTenancy.Payments.PayPal.Dto;

namespace Acme.PhoneBookDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
