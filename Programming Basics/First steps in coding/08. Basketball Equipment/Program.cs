using System;
namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualSubscription = int.Parse(Console.ReadLine());
            double basketballShoes = annualSubscription * 0.6;
            double basketballJersey = basketballShoes * 0.8;
            double basketballBall = basketballJersey * 0.25;
            double basketballAccessories = basketballBall * 0.2;
            double result = annualSubscription + basketballShoes + basketballJersey + basketballBall + basketballAccessories;

            Console.WriteLine(result);
        }
    }
}