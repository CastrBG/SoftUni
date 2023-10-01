using System;
using System.Linq;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usernameInput = Console.ReadLine();
            string correctPassword = string.Join("", usernameInput.ToCharArray().Reverse()) ;
            int incorrectCount = 0;
           

            while (true)
            {
                string passwordInput = Console.ReadLine();
                if (passwordInput == correctPassword)
                {
                    Console.WriteLine($"User {usernameInput} logged in.");
                    break;
                }
                else
                {
                    incorrectCount++;
                    if (incorrectCount == 4)
                    {
                        Console.WriteLine($"User {usernameInput} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                        continue;
                    }
                }
            }
        }
    }
}
