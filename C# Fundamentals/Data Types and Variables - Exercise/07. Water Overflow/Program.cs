using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n ; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input + sum <= 255)
                {
                    sum+= input;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);
        }
    }
}
