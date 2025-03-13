using Lab5.Interfaces;

namespace Lab5.Service
{
    internal class BookLoanFeeCalculation : ILoanFeeCalculation
    {
        public decimal CalculateFee(int days)
        {
            return days * 100m;
        }
    }
}
