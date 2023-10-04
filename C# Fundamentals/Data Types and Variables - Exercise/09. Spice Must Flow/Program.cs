using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int daysMined = 0;
            int spiceMined = 0;

            while (yield >= 100)
            {
                spiceMined += yield;
                daysMined++;
                spiceMined -= 26;
                yield -= 10;

                if (yield < 100)
                {
                    spiceMined -= 26;
                }
            }

            

            Console.WriteLine(daysMined);
            Console.WriteLine(spiceMined);
        }
    }
}
