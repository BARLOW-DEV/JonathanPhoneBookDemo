﻿using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryDemo.MultiTenancy.Payments.Dto;
using LibraryDemo.MultiTenancy.Payments.Stripe.Dto;

namespace LibraryDemo.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}