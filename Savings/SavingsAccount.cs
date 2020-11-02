namespace Savings
{
    public class SavingsAccount
    {
        private static double annualInterestRate;
        private decimal SavingsBalance{get; set;}
        public SavingsAccount(double rate, decimal savingsBalance)
        {
            annualInterestRate = rate;
            SavingsBalance = savingsBalance;
        }

        public decimal CalculateMonthlyInterest()
        {
            return (SavingsBalance * (decimal)(annualInterestRate / 12)) + SavingsBalance;
        }
        public static void ModifyInterestRate(double num)
        {
            annualInterestRate = num;
        }
    }
}