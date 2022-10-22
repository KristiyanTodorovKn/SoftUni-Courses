using System;

namespace Birthday

{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cakePrice = rent * 0.2;
            double drinksPrice = cakePrice - (cakePrice * 0.45);
            double animatorPrice = rent / 3;

            double totalPrice = rent + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
