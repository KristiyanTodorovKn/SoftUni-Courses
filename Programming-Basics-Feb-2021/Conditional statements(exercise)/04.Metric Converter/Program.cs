using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            double metres = 0.0;
            double centimetres = 0.0;
            double milimetres = 0.0;

            if (input == "mm" && input == "cm")
            {
                number = number * 0.1;
                Console.WriteLine($"{number:f3}");
            }
            else if (input == "mm" && output == "m")
            {
                number = number * 0.001;
                Console.WriteLine($"{number:f3}");
            }
            else if (input == "cm" && output == "mm")
            {
                number = number * 10;
                Console.WriteLine($"{number:f3}");
            }
            else if (input == "cm" && input == "m")
            {
                number = number * 0.01;
                Console.WriteLine($"{number:f3}");
            }
            else if (input == "m" && output == "mm")
            {
                number = number * 1000;
                Console.WriteLine($"{number:f3}");
            }
            else if (input == "m" && output == "cm")
            {
                number = number * 100;
                Console.WriteLine($"{number:f3}");
            }
        }
    }
}
