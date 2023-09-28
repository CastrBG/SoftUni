using System;
namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double chickenMenu = 10.35;
            const double fishMenu = 12.4;
            const double vegetarianMenu = 8.15;
            const double delivery = 2.5;

            double chickenOrders = double.Parse(Console.ReadLine()) * chickenMenu;
            double fishOrders = double.Parse(Console.ReadLine()) * fishMenu;
            double vegetarianOrders = double.Parse(Console.ReadLine()) * vegetarianMenu;
            double allOrders = chickenOrders + fishOrders + vegetarianOrders;
            double allOrdersWithDesert = allOrders * 1.2;
            Console.WriteLine(allOrdersWithDesert + delivery);
        }
    }
}