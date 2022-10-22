using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());

            double totalSeats = rows * columns;
            double ticketPrice = 0;

            if (projectionType == "Premiere")
            {
                ticketPrice = 12;
            }
            else if (projectionType == "Normal")
            {
                ticketPrice = 7.50;
            }
            else
            {
                ticketPrice = 5;
            }

            double earnedMoneyFromProjection = totalSeats * ticketPrice;

            Console.WriteLine($"{earnedMoneyFromProjection:f2} leva");
        }
    }
}
