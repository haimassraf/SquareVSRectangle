using System.Net.Http.Headers;

namespace SquareVSRectangle.Exercise4
{
    class DebtAccount : BankAccount
    {
        public double GetDebtBalance()
        {
            return DebtBalance;
        }
    }
}
