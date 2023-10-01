using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashCount = 0;
            int mouseTrashCount = 0;
            int keyboardTrashCount = 0;
            int displayTrashCount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                int currentHeadsetTrash = 0;
                int currentMouseTrash = 0;
                if (i % 2 == 0)
                {
                    headsetTrashCount++;
                    currentHeadsetTrash++;
                }
                if (i % 3 == 0)
                {
                    mouseTrashCount++;
                    currentMouseTrash++;
                }
                if (currentHeadsetTrash == 1 && currentMouseTrash == 1)
                {
                    keyboardTrashCount++;
                }
                if (keyboardTrashCount % 2 == 0 && currentMouseTrash == 1 && currentHeadsetTrash == 1)
                {
                    if (keyboardTrashCount == 0)
                    {
                        continue;
                    }
                    displayTrashCount++;
                }
            }

            double rageExpenses = (headsetTrashCount * headsetPrice) + (mouseTrashCount * mousePrice)+ 
                (keyboardTrashCount * keyboardPrice) + (displayTrashCount * displayPrice);

            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
