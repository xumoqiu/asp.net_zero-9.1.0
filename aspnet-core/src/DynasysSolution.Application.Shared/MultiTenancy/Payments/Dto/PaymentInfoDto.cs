using DynasysSolution.Editions.Dto;

namespace DynasysSolution.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < DynasysSolutionConsts.MinimumUpgradePaymentAmount;
        }
    }
}
