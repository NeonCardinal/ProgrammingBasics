//Chapter PB exam April 2019, Task 011
//15.12.2022, 23:25
using System;

public class EasterCompetition
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        string bestBakerName = "";
        int bestBakerPoints = -1;

        for (int i = 0; i < count; i++)
        {
            string bakerName = Console.ReadLine();
            int points = 0;
            string command = Console.ReadLine();

            while ("Stop" != command)
            {
                points += int.Parse(command);
                command = Console.ReadLine();
            }

            Console.WriteLine($"{bakerName} has {points} points.");
            if (points > bestBakerPoints)
            {
                bestBakerName = bakerName;
                bestBakerPoints = points;
                Console.WriteLine($"{bakerName} is the new number 1!");
            }
        }
        Console.WriteLine($"{bestBakerName} won competition with {bestBakerPoints} points!");
    }
}