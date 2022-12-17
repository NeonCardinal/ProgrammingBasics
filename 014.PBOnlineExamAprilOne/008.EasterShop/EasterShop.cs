//Chapter PB exam April 2019, Task 008
//15.12.2022, 22:37
using System;

public class EasterShop
{
    static void Main()
    {
        int eggsCount = int.Parse(Console.ReadLine());

        int soldEggs = 0;

        string command = Console.ReadLine();

        while(command != "Close")
        {
            if(command == "Buy")
            {
                int eggsToBuy = int.Parse(Console.ReadLine());

                if(eggsToBuy <= eggsCount)
                {
                    soldEggs += eggsToBuy;
                    eggsCount -= eggsToBuy;
                }
                else
                {
                    Console.WriteLine("Not enough eggs in store!");
                    Console.WriteLine($"You can buy only {eggsCount}.");
                    break;
                }
            }
            else if(command == "Fill")
            {
                int eggsToFill = int.Parse(Console.ReadLine());
                eggsCount += eggsToFill;
            }

            command = Console.ReadLine();
        }

        if(command == "Close")
        {
            Console.WriteLine("Store is closed!");
            Console.WriteLine($"{soldEggs} eggs sold.");
        }
    }
}