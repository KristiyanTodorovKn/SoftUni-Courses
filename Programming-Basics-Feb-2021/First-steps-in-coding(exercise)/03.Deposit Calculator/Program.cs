using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            double depositTerm = double.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());
            double interestRate = (depositSum * annualInterestRate) / 100;

            double total = depositSum + depositTerm * (interestRate / 12);

            Console.WriteLine(total);

        }
    }
}
