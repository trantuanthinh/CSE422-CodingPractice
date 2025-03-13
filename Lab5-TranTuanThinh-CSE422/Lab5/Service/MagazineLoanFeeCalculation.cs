using Lab5.Interfaces;

namespace Lab5.Service
{
    internal class MagazineLoanFeeCalculation : ILoanFeeCalculation
    {
        public decimal CalculateFee(int days)
        {
            return days * 200m;
        }
    }
}
