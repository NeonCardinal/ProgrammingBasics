//Chapter PB online exam April 2019, Task 003
//16.12.2022, 20:34
using System;

public class OscarsWeekInCinema
{
    static void Main()
    {
        string movieName = Console.ReadLine();
        string type = Console.ReadLine();
        int tickets = int.Parse(Console.ReadLine());

        double income = 0.00;

        if(type == "normal")
        {
            if(movieName == "A Star Is Born")
            {
                income = tickets * 7.50;
            }
            else if(movieName == "Bohemian Rhapsody")
            {
                income = tickets * 7.35;
            }
            else if(movieName == "Green Book")
            {
                income = tickets * 8.15;
            }
            else if(movieName == "The Favourite")
            {
                income = tickets * 8.75;
            }
        }
        else if(type == "luxury")
        {
            if (movieName == "A Star Is Born")
            {
                income = tickets * 10.50;
            }
            else if (movieName == "Bohemian Rhapsody")
            {
                income = tickets * 9.45;
            }
            else if (movieName == "Green Book")
            {
                income = tickets * 10.25;
            }
            else if (movieName == "The Favourite")
            {
                income = tickets * 11.55;
            }
        }
        else if(type == "ultra luxury")
        {
            if (movieName == "A Star Is Born")
            {
                income = tickets * 13.50;
            }
            else if (movieName == "Bohemian Rhapsody")
            {
                income = tickets * 12.75;
            }
            else if (movieName == "Green Book")
            {
                income = tickets * 13.25;
            }
            else if (movieName == "The Favourite")
            {
                income = tickets * 13.95;
            }
        }

        Console.WriteLine($"{movieName} -> {income:F2} lv.");
    }
}