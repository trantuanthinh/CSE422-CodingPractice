using Lab5.Interfaces;

namespace Lab5.Service
{
    internal class NewspaperLoanFeeCalculation : ILoanFeeCalculation
    {
        public decimal CalculateFee(int days)
        {
            return days * 300m;
        }
    }
}
