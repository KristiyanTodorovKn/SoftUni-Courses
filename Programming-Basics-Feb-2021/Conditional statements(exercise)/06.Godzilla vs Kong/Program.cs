using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double numberOfStatists = double.Parse(Console.ReadLine());
            double priceForClothesPerStatist = double.Parse(Console.ReadLine());
            double decorPrice = budget * 0.1;

            double totalPriceForClothes = numberOfStatists * priceForClothesPerStatist;

            if (numberOfStatists > 150)
            {

                totalPriceForClothes = totalPriceForClothes - totalPriceForClothes * 0.1;
            }

            double total = decorPrice + totalPriceForClothes;

            double moneyLeft = 0;
            double moneyNeeded = 0;

            if (budget >= total)
            {
                moneyLeft = budget - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                moneyNeeded = total - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }

        }
    }
}
