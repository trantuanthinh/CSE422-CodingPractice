using Lab5.Interfaces;

namespace Lab5.Service
{
    internal class Loan
    {
        private ILoanFeeCalculation _loanFeeCalculation;
        public Loan(ILoanFeeCalculation loanFeeCalculation)
        {
            _loanFeeCalculation = loanFeeCalculation;
        }
        public decimal GetLoanFee(int days) => _loanFeeCalculation.CalculateFee(days);

    }
}
