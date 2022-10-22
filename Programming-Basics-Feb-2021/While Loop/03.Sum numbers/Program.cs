using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                sum = sum + input;


                if (sum >= number)
                {
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    input = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
