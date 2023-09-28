using System;
namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double packOfPensPrice = 5.8;
            const double packOfMarkersPrice = 7.2;
            const double detergerntPricePerLitre = 1.2;

            int packsOfPensWanted = int.Parse(Console.ReadLine());
            int packsOfMarkersWanted = int.Parse(Console.ReadLine());
            int litersOfDetergentWanted = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());
            double discountFormula = (double)discountPercentage / 100;
            double neededMoney = ((packOfPensPrice * packsOfPensWanted) + (packOfMarkersPrice * packsOfMarkersWanted) + (litersOfDetergentWanted * detergerntPricePerLitre));
            double result = neededMoney - (neededMoney * discountFormula);
            Console.WriteLine(result);
        }
    }
}