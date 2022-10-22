using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide
{
    class Program
    {
        static void Main(string[] args)
        {

            var number1 = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;


            for (int i = 1; i <= number1; i++)
            {
                var number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }


            double percent1 = (p1 / number1) * 100;
            double percent2 = (p2 / number1) * 100;
            double percent3 = (p3 / number1) * 100;

            Console.WriteLine("{0:f2}%", percent1);
            Console.WriteLine("{0:f2}%", percent2);
            Console.WriteLine("{0:f2}%", percent3);
        }
    }
}