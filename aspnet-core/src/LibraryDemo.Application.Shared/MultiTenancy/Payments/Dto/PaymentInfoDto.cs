using LibraryDemo.Editions.Dto;

namespace LibraryDemo.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < LibraryDemoConsts.MinimumUpgradePaymentAmount;
        }
    }
}
