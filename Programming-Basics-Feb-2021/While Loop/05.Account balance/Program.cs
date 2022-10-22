﻿using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            string input;

            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double money = double.Parse(input);

                if (money < 0.0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {money:f2}");
                sum += money;
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
