using System;
namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentDecoration = double.Parse(Console.ReadLine()) / 100;

            double volume = (length * width * height) * 0.001;
            double result = volume * (1 - percentDecoration);
            Console.WriteLine(result);



        }
    }
}