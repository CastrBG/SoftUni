using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = { 2,3,6,7,10};
            int maxDivision = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (number % array[i] == 0)
                {
                    maxDivision = array[i];
                }
            }
            if (maxDivision == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {maxDivision}");

            }
        }
    }
}
