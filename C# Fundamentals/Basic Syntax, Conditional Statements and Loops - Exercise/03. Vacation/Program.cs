using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCapacity = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0;
            double totalSum = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        pricePerPerson = 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        pricePerPerson = 9.80;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        pricePerPerson = 10.46;
                    }
                    totalSum = groupCapacity * pricePerPerson;
                    if (groupCapacity >= 30)
                    {
                        totalSum *= 0.85;
                    }
                        break;
                case "Business":
                    if (dayOfWeek == "Friday")
                    {
                        pricePerPerson = 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        pricePerPerson = 15.60;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        pricePerPerson = 16;
                    }
                    totalSum = groupCapacity * pricePerPerson;
                    if (groupCapacity >= 100)
                    {
                        totalSum = totalSum - (pricePerPerson * 10);
                    }
                    break;
                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        pricePerPerson = 15;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        pricePerPerson = 20;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        pricePerPerson = 22.5;
                    }
                    totalSum = groupCapacity * pricePerPerson;
                    if (groupCapacity >= 10 && groupCapacity <= 20)
                    {
                        totalSum *= 0.95;
                    }
                    break;
                default:
                    break;
            }


            Console.WriteLine($"Total price: {totalSum:f2}");
        }
    }
}
