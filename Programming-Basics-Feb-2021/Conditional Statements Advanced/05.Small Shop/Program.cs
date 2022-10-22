using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double coffeePrice = 0.0;
            double waterPrice = 0.0;
            double beerPrice = 0.0;
            double sweetsPrice = 0.0;
            double peanutsPrice = 0.0;
            

            if (town == "Sofia") 
            {               
                if (product == "coffee")
                {
                    coffeePrice = 0.5;
                    double total = quantity * coffeePrice;
                    Console.WriteLine(total);
                }
                else if (product == "water")
                {
                    waterPrice = 0.8;
                    double total = quantity * waterPrice;
                    Console.WriteLine(total);
                }
                else if (product == "beer")
                {
                    beerPrice = 1.2;
                    double total = quantity * beerPrice;
                    Console.WriteLine(total);
                }
                else if (product == "sweets")
                {
                    sweetsPrice = 1.45;
                    double total = quantity * sweetsPrice;
                    Console.WriteLine(total);
                }
                else
                {
                    peanutsPrice = 1.6;
                    double total = quantity * peanutsPrice;
                    Console.WriteLine(total);
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    coffeePrice = 0.4;
                    double total = quantity * coffeePrice;
                    Console.WriteLine(total);
                }
                else if (product == "water")
                {
                    waterPrice = 0.7;
                    double total = quantity * waterPrice;
                    Console.WriteLine(total);
                }
                else if (product == "beer")
                {
                    beerPrice = 1.15;
                    double total = quantity * beerPrice;
                    Console.WriteLine(total);
                }
                else if (product == "sweets")
                {
                    sweetsPrice = 1.3;
                    double total = quantity * sweetsPrice;
                    Console.WriteLine(total);
                }
                else
                {
                    peanutsPrice = 1.5;
                    double total = quantity * peanutsPrice;
                    Console.WriteLine(total);
                }

            }
            else
            {
                if (product == "coffee")
                {
                    coffeePrice = 0.45;
                    double total = quantity * coffeePrice;
                    Console.WriteLine(total);
                }
                else if (product == "water")
                {
                    waterPrice = 0.7;
                    double total = quantity * waterPrice;
                    Console.WriteLine(total);
                }
                else if (product == "beer")
                {
                    beerPrice = 1.1;
                    double total = quantity * beerPrice;
                    Console.WriteLine(total);
                }
                else if (product == "sweets")
                {
                    sweetsPrice = 1.35;
                    double total = quantity * sweetsPrice;
                    Console.WriteLine(total);
                }
                else
                {
                    peanutsPrice = 1.55;
                    double total = quantity * peanutsPrice;
                    Console.WriteLine(total);
                }

            }
        }
    }
}
