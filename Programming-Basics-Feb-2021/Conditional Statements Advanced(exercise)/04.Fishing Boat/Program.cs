using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            int[] boatPrice = { 3000, 4200, 4200, 2600 };
            double totalCost = 0;

            switch (season)
            {
                case "Spring":
                    if (fishermen <= 6)
                    {
                        totalCost = boatPrice[0] * 0.9;
                        if (fishermen % 2 == 0)
                        {
                            totalCost *= 0.95;
                        }
                    }
                    if (fishermen >= 7 && fishermen <= 11)
                    {
                        totalCost = boatPrice[0] * 0.85;
                        if (fishermen % 2 == 0)
                        {
                            totalCost *= 0.95;
                        }
                    }
                    if (fishermen >= 12)
                    {
                        totalCost = boatPrice[0] * 0.75;
                        if (fishermen % 2 == 0)
                        {
                            totalCost *= 0.95;
                        }
                    }
                    break;
                case "Summer":
                    if (fishermen <= 6)
                    {
                        totalCost = boatPrice[1] * 0.9;
                        if (fishermen % 2 == 0)
                        {
                            totalCost *= 0.95;
                        }
                    }
                    if (fishermen >= 7 && fishermen <= 11)
                    {
                        totalCost = boatPrice[1] * 0.85;
                        if (fishermen % 2 == 0)
                        {
                            totalCost *= 0.95;
                        }
                    }
                    if (fishermen >= 12)
                    {
                        totalCost = boatPrice[1] * 0.75;
                        if (fishermen % 2 == 0)
                        {
                            totalCost *= 0.95;
                        }
                    }
                    break;
                case "Autumn":
                    if (fishermen <= 6)
                    {
                        totalCost = boatPrice[2] * 0.9;
                    }
                    if (fishermen >= 7 && fishermen <= 11)
                    {
                        totalCost = boatPrice[2] * 0.85;
                    }
                    if (fishermen >= 12)
                    {
                        totalCost = boatPrice[2] * 0.75;
                    }
                    break;
                case "Winter":
                    if (fishermen <= 6)
                    {
                        totalCost = boatPrice[3] * 0.9;
                        if (fishermen % 2 == 0)
                        {
                            totalCost *= 0.95;
                        }
                    }
                    if (fishermen >= 7 && fishermen <= 11)
                    {
                        totalCost = boatPrice[3] * 0.85;
                        if (fishermen % 2 == 0)
                        {
                            totalCost *= 0.95;
                        }
                    }
                    if (fishermen >= 12)
                    {
                        totalCost = boatPrice[3] * 0.75;
                        if (fishermen % 2 == 0)
                        {
                            totalCost *= 0.95;
                        }
                    }
                    break;
            }

            if (budget >= totalCost)
            {
                Console.WriteLine($"Yes! You have {budget - totalCost:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget:F2} leva.");
            }
        }
    }
}
