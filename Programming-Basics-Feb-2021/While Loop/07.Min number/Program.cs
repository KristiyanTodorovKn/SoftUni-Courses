using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double minValue = double.MaxValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                double currentNum = double.Parse(input);

                if (currentNum < minValue)
                {
                    minValue = currentNum;
                }

            }
            Console.WriteLine(minValue);
        }
    }
}
