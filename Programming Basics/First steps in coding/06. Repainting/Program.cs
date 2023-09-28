using System;
namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double plasticPrice = 1.5;
            const double paintPrice = 14.5;
            const double paintDiluterPrice = 5;
            const double moneyForBags = 0.4;

            double plasticFormula = (double.Parse(Console.ReadLine()) + 2) * plasticPrice;
            double paintFormula = double.Parse(Console.ReadLine()) * 1.1 * paintPrice;
            double diluteFormula = double.Parse(Console.ReadLine()) * paintDiluterPrice;
            double workHours = double.Parse(Console.ReadLine());
            double materialMoney = plasticFormula + paintFormula + diluteFormula + moneyForBags;
            double workerPayPerHour = materialMoney * 0.3;
            double workerSalary = workerPayPerHour * workHours;
            double result = materialMoney + workerSalary;
            Console.WriteLine(result);
        }
    }
}