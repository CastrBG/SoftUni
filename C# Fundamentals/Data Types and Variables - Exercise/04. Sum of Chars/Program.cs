using System;

namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int charSum = 0;

            for (int i = 1; i <= n; i++)
            {
                char currentChar = Console.ReadLine()[0];
                charSum += currentChar;

            }
            Console.WriteLine($"The sum equals: {charSum}");
        }
    }
}
