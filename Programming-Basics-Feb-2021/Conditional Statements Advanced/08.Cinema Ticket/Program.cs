using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            int ticketPrice = 0;

            if (day == "Monday")
            {
                ticketPrice = 12;
                Console.WriteLine(ticketPrice);
            }
            else if (day == "Tuesday")
            {
                ticketPrice = 12;
                Console.WriteLine(ticketPrice);
            }
            else if (day == "Wednesday")
            {
                ticketPrice = 14;
                Console.WriteLine(ticketPrice);
            }
            else if (day == "Thursday")
            {
                ticketPrice = 14;
                Console.WriteLine(ticketPrice);
            }
            else if (day == "Friday")
            {
                ticketPrice = 12;
                Console.WriteLine(ticketPrice);
            }
            else if (day == "Saturday")
            {
                ticketPrice = 16;
                Console.WriteLine(ticketPrice);
            }
            else
            {
                ticketPrice = 16;
                Console.WriteLine(ticketPrice);
            }
        }
    }
}
