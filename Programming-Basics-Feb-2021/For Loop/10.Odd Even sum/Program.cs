using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(i % 2 == 0)
                {
                    even = even + number;
                }
                else
                {
                    odd = odd + number;
                }
            }

            if (even == odd)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                int diff = Math.Abs(even - odd);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
