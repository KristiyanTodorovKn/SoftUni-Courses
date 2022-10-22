using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            


            for (int i = 1; i <= n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());



                if (currentNum < 200)
                {
                    number += currentNum;
                    p1++;

                }
                else if (currentNum >= 200 && currentNum <= 399)
                {
                    number += currentNum;
                    p2++;


                }
                else if (currentNum >= 400 && currentNum <= 599)
                {
                    number += currentNum;
                    p3++;


                }
                else if (currentNum >= 600 && currentNum <= 799)
                {
                    number += currentNum;
                    p4++;

                }
                else if (currentNum >= 800 && currentNum <= 1000)
                {

                    number += currentNum;
                    p5++;
                }


            }

            Console.WriteLine($"{(100 * p1) / n:f2}%");
            Console.WriteLine($"{(100 * p2) / n:f2}%");
            Console.WriteLine($"{(100 * p3) / n:f2}%");
            Console.WriteLine($"{(100 * p4) / n:f2}%");
            Console.WriteLine($"{(100 * p5) / n:f2}%");


        }
    }
}
