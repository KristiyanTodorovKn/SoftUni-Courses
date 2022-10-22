using System;

namespace _08.Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogFoodPrice = 2.5;
            double otherAnimalsFoodPrice = 4;

            double dogs = double.Parse(Console.ReadLine());
            double otherAnimals = double.Parse(Console.ReadLine());

            double dogsFoodTotalPrice = dogs * dogFoodPrice;
            double otherAnimalsTotalFoodPrice = otherAnimalsFoodPrice * otherAnimals;

            double totalPrice = dogsFoodTotalPrice + otherAnimalsTotalFoodPrice;

            Console.WriteLine($"{totalPrice} lv.");


        }
    }
}
