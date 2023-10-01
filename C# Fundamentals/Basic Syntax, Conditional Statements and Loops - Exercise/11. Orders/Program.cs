using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderAmount = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = 0; i < orderAmount; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double orderPrice = ((days * capsulesCount) * capsulePrice);
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                totalPrice+= orderPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
