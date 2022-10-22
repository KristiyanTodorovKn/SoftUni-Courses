using System;

namespace _07.Store_for_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.6;
            double talkingDollPrice = 3;
            double bearPrice = 4.1;
            double minionPrice = 8.2;
            double truckPrice = 2;

            double moneyNeededForTrip = double.Parse(Console.ReadLine());
            double puzzleQuantity = double.Parse(Console.ReadLine());
            double talkingDollQuantity = double.Parse(Console.ReadLine());
            double bearQuantity = double.Parse(Console.ReadLine());
            double minionQuantity = double.Parse(Console.ReadLine());
            double truckQuantity = double.Parse(Console.ReadLine());

            double totalPuzzlePrice = puzzlePrice * puzzleQuantity;
            double totalTalkingDollPrice = talkingDollPrice * talkingDollQuantity;
            double totalBearPrice = bearPrice * bearQuantity;
            double totalMinionPrice = minionPrice * minionQuantity;
            double totalTruckPrice = truckPrice * truckQuantity;

            double toysQuantity = puzzleQuantity + talkingDollQuantity + bearQuantity + minionQuantity + truckQuantity;

            double totalEarnings = totalBearPrice + totalMinionPrice + totalPuzzlePrice + totalTalkingDollPrice + totalTruckPrice;
            double total = totalEarnings - (totalEarnings * 0.1);

           

            if (toysQuantity >= 50)
            {
               total = total - (total * 0.25);
            }

            if (total > moneyNeededForTrip)
            {
                double moneyLeft = total - moneyNeededForTrip;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else if (total < moneyNeededForTrip)
            {
                double moneyNeeded = moneyNeededForTrip - total;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}
