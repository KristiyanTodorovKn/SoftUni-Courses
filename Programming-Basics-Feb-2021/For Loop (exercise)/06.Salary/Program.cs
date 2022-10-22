﻿using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());


            for (int i = 0; i < numOfTabs; i++)
            {
                string website = Console.ReadLine();

                switch (website)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }

        }
    }
}
