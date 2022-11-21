﻿//Chapter Conditional statements - exercise, Task 003
//19.11.2022, 00:42
using System;

public class TimePlusFifteenMinutes
{
    static void Main()
    {
        //Read input
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        //Logic and calculations
        minutes += 15;

        if (minutes > 59)
        {
            hours++;
            minutes -= 60;
        }
        if (hours > 23)
        {
            hours -= 24;
        }

        if (minutes < 10)
        {
            Console.WriteLine($"{hours}:0{minutes}");
        }
        else
        {
            Console.WriteLine($"{hours}:{minutes}");
        }
    }
}