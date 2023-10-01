using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int studentsAmount = int.Parse(Console.ReadLine());
            double lightsaberCost = double.Parse(Console.ReadLine());
            double robeCost = double.Parse(Console.ReadLine());
            double beltsCost = double.Parse(Console.ReadLine());


            double lightsaberAmount = Math.Ceiling( studentsAmount * 1.1);
            int beltsAmount = studentsAmount;
            int n = studentsAmount;
            while (true)
            {
                if (n - 6 >= 0)
                {
                    n -= 6;
                    beltsAmount--;
                }
                else
                {
                    break;
                }
            }

            double sum = (lightsaberCost * lightsaberAmount) + (robeCost * studentsAmount) + (beltsAmount * beltsCost);
            if (moneyAvailable - sum >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(sum - moneyAvailable):f2}lv more.");
            }
        }
    }
}
