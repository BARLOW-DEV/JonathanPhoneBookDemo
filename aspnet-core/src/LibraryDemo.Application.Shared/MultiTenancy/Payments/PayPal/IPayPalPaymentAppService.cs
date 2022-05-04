using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryDemo.MultiTenancy.Payments.PayPal.Dto;

namespace LibraryDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
