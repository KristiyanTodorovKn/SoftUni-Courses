using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthInCm = double.Parse(Console.ReadLine());
            double widthInCm = double.Parse(Console.ReadLine());
            double heigthInCm = double.Parse(Console.ReadLine());
            double percentInput = double.Parse(Console.ReadLine());

            double volumeInCm = lengthInCm * widthInCm * heigthInCm;
            double volumeInLiters = volumeInCm * 0.001;
            double percent = percentInput * 0.01;

            double litersNeeded = volumeInLiters * (1 - percent);

            Console.WriteLine(litersNeeded);

        }
    }
}
