using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingIndex = int.Parse(Console.ReadLine());
            int endingIndex = int.Parse(Console.ReadLine());

            for (int i = startingIndex; i <= endingIndex; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
