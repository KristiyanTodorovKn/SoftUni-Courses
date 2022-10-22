using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
           
            double max = double.MinValue;


            while ((input = Console.ReadLine()) != "Stop")
            {
                double currentNum = double.Parse(input);



                if (currentNum > max)
                {
                    max = currentNum;
                }


            }

            Console.WriteLine(max);
        }
    }
}
