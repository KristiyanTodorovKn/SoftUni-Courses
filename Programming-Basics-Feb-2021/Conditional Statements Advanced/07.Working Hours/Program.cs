﻿using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hour >= 10 && hour <= 18)
            {
                if (day == "Monday")
                {
                    Console.WriteLine("open");
                }
                else if (day == "Tuesday")
                {
                    Console.WriteLine("open");
                }
                else if (day == "Wednesday")
                {
                    Console.WriteLine("open");
                }
                else if (day == "Thursday")
                {
                    Console.WriteLine("open");
                }
                else if (day == "Friday")
                {
                    Console.WriteLine("open");
                }
                else if (day == "Saturday")
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
