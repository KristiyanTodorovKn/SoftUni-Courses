using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());


            double discount = 0.0;
            double studioPrice = 0.0;
            double apartmentPice = 0.0;
            double totalStudio = 0.0;
            double totalApartment = 0.0;

            if (month == "May" || month == "October")
            {
                apartmentPice = 65;
                studioPrice = 50;
                if (nights > 7 && nights <= 14)

                {
                    discount = 0.05;
                }
                if (nights > 14)
                {
                    discount = 0.3;
                    apartmentPice = apartmentPice - (apartmentPice * 0.1);
                }
                totalApartment = apartmentPice * nights;
                totalStudio = studioPrice * nights - (studioPrice * discount * nights);
                Console.WriteLine($"Apartment: { totalApartment:f2} lv.");
                Console.WriteLine($"Studio: {totalStudio:f2} lv.");

            }
            else if (month == "June" || month == "September")
            {
                apartmentPice = 68.70;
                studioPrice = 75.20;

                if (nights > 14)
                {
                    discount = 0.2;
                    apartmentPice = apartmentPice - (apartmentPice * 0.1);
                    studioPrice = studioPrice - studioPrice * 0.2;

                }
                totalStudio = studioPrice * nights;
                totalApartment = apartmentPice * nights;
                Console.WriteLine($"Apartment: { totalApartment:f2} lv.");
                Console.WriteLine($"Studio: {totalStudio:f2} lv.");
            }
            else if (month == "July" || month == "August")
            {
                apartmentPice = 77;
                studioPrice = 76;
                if (nights > 14)
                {
                    apartmentPice = apartmentPice - apartmentPice * 0.1;
                }
                totalApartment = apartmentPice * nights;
                totalStudio = studioPrice * nights;
                Console.WriteLine($"Apartment: { totalApartment:f2} lv.");
                Console.WriteLine($"Studio: {totalStudio:f2} lv.");
            }




        }
    }
}
