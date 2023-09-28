using System;
namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int readPagesPerHour = int.Parse(Console.ReadLine());
            int daysToReadBook = int.Parse(Console.ReadLine());
            int result = bookPages / readPagesPerHour / daysToReadBook;
            Console.WriteLine(result);
        }
    }
}