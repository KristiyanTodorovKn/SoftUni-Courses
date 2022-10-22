using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {

            }

            else if (number <= 99 || number >= 201)
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
