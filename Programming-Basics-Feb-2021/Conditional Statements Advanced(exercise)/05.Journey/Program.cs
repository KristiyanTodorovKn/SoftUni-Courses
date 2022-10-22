using System;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double discount = 0.0;
            double total = 0.0;
            string holidayType;

            if (budjet <= 100)
            {
                if (season == "summer")
                {
                    discount = budjet - (budjet * 0.3);
                }
                else if (season == "winter")
                {
                    discount = budjet - (budjet * 0.7);
                }

            }
            else if (budjet > 100 && budjet <= 1000)
            {
                if (season == "summer")
                {
                    discount = budjet - (budjet * 0.4);
                }
                else if (season == "winter")
                {
                    discount = budjet - (budjet * 0.8);
                }
            }
            else if (budjet > 1001)
            {
                discount = budjet - (budjet * 0.9);
            }
            total = budjet - discount;

            switch (season)
            {
                case "summer":

                    if (budjet <= 100)
                    {
                        holidayType = "Camp";
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"{ holidayType} - {total:f2}");
                    }
                    else if (budjet > 100 && budjet <= 1000)
                    {
                        holidayType = "Camp";
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"{holidayType} - {total:f2}");
                    }
                    else if (budjet > 1000)
                    {
                        holidayType = "Hotel";
                        Console.WriteLine("Somewhere in Europe");
                        Console.WriteLine($"{holidayType} - {total:f2}");
                    }
                    break;
                case "winter":
                    holidayType = "Hotel";
                    if (budjet <= 100)
                    {
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"{holidayType} - {total:f2}");

                    }
                    else if (budjet > 100 && budjet <= 1000)
                    {
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"{holidayType} - {total:F2}");
                    }
                    else if (budjet > 1000)
                    {
                        Console.WriteLine("Somewhere in Europe");
                        Console.WriteLine($"{holidayType} - {total:f2}");
                    }
                    break;


            }


        }
    }
}
