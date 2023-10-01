using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string stageOfLife = string.Empty;
            if (age >= 0 && age <= 2)
            {
                stageOfLife = "baby";
            }
            else if (age <= 13)
            {
                stageOfLife = "child";
            }
            else if(age <=19)
            {
                stageOfLife = "teenager";
            }
            else if (age <= 65)
            {
                stageOfLife = "adult";
            }
            else if (age >= 66)
            {
                stageOfLife = "elder";
            }
            
            Console.WriteLine(stageOfLife);
        }
    }
}
