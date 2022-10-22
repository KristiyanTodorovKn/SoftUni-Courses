using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            double flowersCount = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double rosePrice = 5;
            double dahliaPrice = 3.8;
            double tulipPrice = 2.8;
            double narcissusPrice = 3;
            double gladiolusPrice = 2.5;

            double total = 0.0;

            if (typeOfFlower == "Roses")
            {
                total = flowersCount * rosePrice;
                if (flowersCount > 80)
                {
                    total = total - (total * 0.1);
                }
            }
            else if (typeOfFlower == "Dahlias")
            {
                total = flowersCount * dahliaPrice;
                if (flowersCount > 90)
                {
                    total = total - (total * 0.15);
                }

            }
            else if (typeOfFlower == "Tulips")
            {
                total = flowersCount * tulipPrice;
                if (flowersCount > 80)
                {
                    total = total - (total * 0.15);
                }
            }
            else if (typeOfFlower == "Narcissus")
            {
                total = flowersCount * narcissusPrice;
                if (flowersCount < 120)
                {
                    total = total + (total * 0.15);
                }
            }
            else
            {
                total = flowersCount * gladiolusPrice;
                if (flowersCount < 80)
                {
                    total = total + (total * 0.2);
                }
            }
            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typeOfFlower} and {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
            }
        }
    }
}
