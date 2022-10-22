
using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double bakers = double.Parse(Console.ReadLine());
            double cakes = double.Parse(Console.ReadLine());
            double waffles = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            double cakePrice = 45;
            double wafflePrice = 5.8;
            double pancakePrice = 3.2;

            double cakeTotalPrice = cakes * cakePrice;
            double waffleTotalPrice = wafflePrice * waffles;
            double pancakeTotalPrice = pancakes * pancakePrice;

            double moneyEarnedForDay = (cakeTotalPrice + waffleTotalPrice + pancakeTotalPrice) * bakers;
            double moneyEarnedForCampaign = moneyEarnedForDay * days;

            double total = moneyEarnedForCampaign - (moneyEarnedForCampaign / 8);

            Console.WriteLine(total);
        }
    }
}
