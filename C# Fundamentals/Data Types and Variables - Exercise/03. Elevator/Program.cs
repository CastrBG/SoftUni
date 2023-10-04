using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int coursesNeeded = 0;

            while (numberOfPeople - elevatorCapacity > 0)
            {
                numberOfPeople -= elevatorCapacity;
                coursesNeeded++;
            }
            if (numberOfPeople > 0)
            {
                numberOfPeople = 0;
                coursesNeeded++;
            }
            
            Console.WriteLine(coursesNeeded);
        }
    }
}
