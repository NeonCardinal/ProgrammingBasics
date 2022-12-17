//Chapter PB exam April 2019, Task 005
//15.12.2022, 21:11
using System;

public class EasterTrip
{
    static void Main()
    {
        string dest = Console.ReadLine();
        string date = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double price = 0.00;

        if(dest == "France")
        {
            if(date == "21-23")
            {
                price = nights * 30.00;
            }
            else if(date == "24-27")
            {
                price = nights * 35.00;
            }
            else if(date == "28-31")
            {
                price = nights * 40.00;
            }
        }
        else if(dest == "Italy")
        {
            if (date == "21-23")
            {
                price = nights * 28.00;
            }
            else if (date == "24-27")
            {
                price = nights * 32.00;
            }
            else if (date == "28-31")
            {
                price = nights * 39.00;
            }
        }
        else if(dest == "Germany")
        {
            if (date == "21-23")
            {
                price = nights * 32.00;
            }
            else if (date == "24-27")
            {
                price = nights * 37.00;
            }
            else if (date == "28-31")
            {
                price = nights * 43.00;
            }
        }

        Console.WriteLine($"Easter trip to {dest} : {price:F2} leva.");
    }
}