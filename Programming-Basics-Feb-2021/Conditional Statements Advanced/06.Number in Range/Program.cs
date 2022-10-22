using System;

namespace _06._Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= -100 && number <= -1)
            {
                Console.WriteLine("Yes");
            }
            else if (number == 0)
            {
                Console.WriteLine("No");
            }
            else if (number >= 1 && number <= 100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
