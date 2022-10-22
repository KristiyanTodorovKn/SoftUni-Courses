using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.0;
            double total = 0.0;


            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {

                    price = 2.50;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");

                }
                else if (fruit == "apple")
                {
                    price = 1.20;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");

                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }

            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.90;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 4.20;
                    total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }


    }
}
