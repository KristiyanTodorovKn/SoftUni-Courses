using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0;

            if (symbol == '+')
            {
                result = numberOne + numberTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} + {numberTwo} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{numberOne} + {numberTwo} = {result} - odd");
                }
            }
            else if (symbol == '-')
            {
                result = numberOne - numberTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} - {numberTwo} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{numberOne} - {numberTwo} = {result} - odd");
                }
            }
            else if (symbol == '*')
            {
                result = numberOne * numberTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} * {numberTwo} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{numberOne} * {numberTwo} = {result} - odd");
                }
            }
            else if (symbol == '/')
            {
                if (numberOne != 0 && numberTwo != 0)
                {
                    result = numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} / {numberTwo} = {result:f2}");

                }
                else
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }
            }
            else
            {

                if (numberOne != 0 && numberTwo != 0)
                {
                    result = numberOne % numberTwo;
                    Console.WriteLine($"{numberOne} % {numberTwo} = {result}");

                }
                else
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }
            }
        }
    }
}
