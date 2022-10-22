using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPricePerKilo = double.Parse(Console.ReadLine());
            double bananasKg = double.Parse(Console.ReadLine());
            double orangeKg = double.Parse(Console.ReadLine());
            double raspberryKg = double.Parse(Console.ReadLine());
            double strawberryKg = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberryPricePerKilo / 2;
            double orangesPrice = raspberriesPrice - (raspberriesPrice * 0.4);
            double bananasPrice = raspberriesPrice - (raspberriesPrice * 0.8);

            double strawberriesTotalPrice = strawberryPricePerKilo * strawberryKg;
            double bananasTotalPrice = bananasKg * bananasPrice;
            double orangeTotalPrice = orangeKg * orangesPrice;
            double raspberryTotalPrice = raspberriesPrice * raspberryKg;

            double totalSum = strawberriesTotalPrice + bananasTotalPrice + orangeTotalPrice + raspberryTotalPrice;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
