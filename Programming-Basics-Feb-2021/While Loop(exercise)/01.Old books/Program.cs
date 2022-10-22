using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int counter = 0;

            while (true)
            {
                string currentBook = Console.ReadLine();

                if (currentBook == favouriteBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                if (currentBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
                counter++;
            }

        }
    }
}
