using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount saver1 = new SavingsAccount(0.04, 2000M);
            SavingsAccount saver2 = new SavingsAccount(0.04, 3000M);
            Console.WriteLine($"The new balance for saver 1 is: {saver1.CalculateMonthlyInterest():C} while that of saver2 is {saver2.CalculateMonthlyInterest():C}");

            SavingsAccount.ModifyInterestRate(0.05);

            Console.WriteLine($"The new balance for saver 1 after modifying interest rate is: {saver1.CalculateMonthlyInterest():C} while that of saver2 is {saver2.CalculateMonthlyInterest():C}");

        }
    }
}
