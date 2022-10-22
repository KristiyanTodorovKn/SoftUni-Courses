using System;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPages = double.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            double numberOfDays = double.Parse(Console.ReadLine());

            double totalTimeForReadingBook = numberOfPages / pagesPerHour;
            double hoursNeededPerDay = totalTimeForReadingBook / numberOfDays;

            Console.WriteLine(hoursNeededPerDay);
        }
    }
}
