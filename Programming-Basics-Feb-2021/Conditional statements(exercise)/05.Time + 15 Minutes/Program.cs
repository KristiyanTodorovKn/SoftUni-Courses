using System;

namespace _05.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes < 45)
            {
                minutes += 15;
            }
            else if (minutes >= 45)
            {
                minutes = (minutes + 15) - 60;
                hours += 1;
            }
            if (hours == 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
