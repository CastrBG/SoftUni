using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;
            while (command != "Start")
            {
                double input = double.Parse(command);
                switch (input)
                {
                    case 0.1: sum += 0.1; break;

                    case 0.2: sum += 0.2; break;

                    case 0.5: sum += 0.5; break;

                    case 1: sum += 1; break;

                    case 2: sum += 2; break;

                    default:
                        Console.WriteLine($"Cannot accept {input}");
                        command = Console.ReadLine();
                        continue;
                }
                command = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                bool canPurchase = true;
                double productPrice = 0;
                switch (product)
                {
                    case "Nuts": 
                        double nutsPrice = 2.0;
                        productPrice = nutsPrice;
                        if (sum - nutsPrice < 0)
                        {
                            canPurchase= false;
                        }
                        break;
                    case "Water":
                        double waterPrice = 0.7;
                        productPrice = waterPrice;
                        if (sum - waterPrice < 0)
                        {
                            canPurchase = false;
                        }
                        break;
                    case "Crisps":
                        double crispsPrice = 1.5;
                        productPrice = crispsPrice;
                        if (sum - crispsPrice < 0)
                        {
                            canPurchase = false;
                        }
                        break;
                    case "Soda":
                        double sodaPrice = 0.8;
                        productPrice = sodaPrice;
                        if (sum - sodaPrice < 0)
                        {
                            canPurchase = false;
                        }
                        break;
                    case "Coke":
                        double cokePrice = 1.0;
                        productPrice = cokePrice;
                        if (sum - cokePrice < 0)
                        {
                            canPurchase = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product= Console.ReadLine();
                         continue;
                }
                if (canPurchase)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sum -= productPrice;
                }
                else
                {
                    Console.WriteLine("Sorry not enough money");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
