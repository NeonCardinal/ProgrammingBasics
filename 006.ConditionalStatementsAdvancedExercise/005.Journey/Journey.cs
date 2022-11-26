//Chapter Conditional statements advanced - exercise, Task 005
//26.11.2022, 19:15
using System;

public class Journey
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();

        string place = string.Empty;
        string type = string.Empty;
        double price = 0.0;

        if(budjet <= 100)
        {
            place = "Bulgaria";

            if (season == "summer")
            {
                price = budjet * 0.30;
                type = "Camp";
            }
            else if(season == "winter")
            {
                price = budjet * 0.70;
                type = "Hotel";
            }
        }
        else if(budjet > 100 && budjet <= 1000)
        {
            place = "Balkans";

            if(season == "summer")
            {
                price = budjet * 0.40;
                type = "Camp";
            }
            else if(season == "winter")
            {
                price = budjet * 0.80;
                type = "Hotel";
            }
        }
        else if(budjet > 1000)
        {
            place = "Europe";
            type = "Hotel";
            price = budjet * 0.90;           
        }

        Console.WriteLine($"Somewhere in {place}");
        Console.WriteLine($"{type} - {price:F2}");
    }
}
