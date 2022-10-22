using System;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double percent = 0.0;
            double total = 0.0;

            if (sales < 0)
            {
                Console.WriteLine("error");
            }

            else if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    percent = 0.05;
                    total = percent * sales;
                    Console.WriteLine($"{total:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    percent = 0.07;
                    total = sales * percent;
                    Console.WriteLine($"{total:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    percent = 0.08;
                    total = sales * percent;
                    Console.WriteLine($"{total:f2}");
                }
                else if (sales > 10000)
                {
                    percent = 0.12;
                    total = sales * percent;
                    Console.WriteLine($"{total:f2}");
                }

            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    percent = 0.045;
                    total = percent * sales;
                    Console.WriteLine($"{total:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    percent = 0.075;
                    total = sales * percent;
                    Console.WriteLine($"{total:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    percent = 0.1;
                    total = sales * percent;
                    Console.WriteLine($"{total:f2}");
                }
                else if (sales > 10000)


                {
                    percent = 0.13;
                    total = sales * percent;
                    Console.WriteLine($"{total:f2}");
                }
            }


            else if (town == "Plovdiv")
            {

                if (sales >= 0 && sales <= 500)
                {
                    percent = 0.055;
                    total = percent * sales;
                    Console.WriteLine($"{total:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    percent = 0.08;
                    total = sales * percent;
                    Console.WriteLine($"{total:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    percent = 0.12;
                    total = sales * percent;
                    Console.WriteLine($"{total:f2}");
                }
                else if (sales > 10000)
                {
                    percent = 0.145;
                    total = sales * percent;
                    Console.WriteLine($"{total:f2}");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
