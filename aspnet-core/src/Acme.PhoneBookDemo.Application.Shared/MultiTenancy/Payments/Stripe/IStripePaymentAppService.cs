using System.Threading.Tasks;
using Abp.Application.Services;
using Acme.PhoneBookDemo.MultiTenancy.Payments.Dto;
using Acme.PhoneBookDemo.MultiTenancy.Payments.Stripe.Dto;

namespace Acme.PhoneBookDemo.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}