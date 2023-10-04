using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            double volumeResult = 0.0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine(); 
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                
                double currentVolume = Math.PI * Math.Pow(radius,2) * height; 
                if (currentVolume > volumeResult)
                {
                    result = name;
                    volumeResult = currentVolume;
                }

            }

            Console.WriteLine(result);
        }
    }
}
