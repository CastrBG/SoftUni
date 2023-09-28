using System;
namespace _01._USD_to_BGN_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputDollars = double.Parse(Console.ReadLine());
            double fixedValue = 1.79549;
            Console.WriteLine(inputDollars * fixedValue); 
        }
    }
}