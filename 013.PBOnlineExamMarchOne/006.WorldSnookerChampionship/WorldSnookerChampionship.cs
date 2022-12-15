//Chapter PB exam March 2019, Task 006
//14.12.2022, 01:01
using System;

public class WorldSnookerChampionship
{
    static void Main()
    {
        string type = Console.ReadLine();
        string ticketType = Console.ReadLine();
        int ticketsCnt = int.Parse(Console.ReadLine());
        string pic = Console.ReadLine();

        double price = 0.00;
        double discount = 0.00;

        if(type == "Quarter final")
        {
            if(ticketType == "Standard")
            {
                price = ticketsCnt * 55.50;
            }
            else if(ticketType == "Premium")
            {
                price = ticketsCnt * 105.20;
            }
            else if(ticketType == "VIP")
            {
                price = ticketsCnt * 118.90;
            }
        }
        else if(type == "Semi final")
        {
            if (ticketType == "Standard")
            {
                price = ticketsCnt * 75.88;
            }
            else if (ticketType == "Premium")
            {
                price = ticketsCnt * 125.22;
            }
            else if (ticketType == "VIP")
            {
                price = ticketsCnt * 300.40;
            }
        }
        else if(type == "Final")
        {
            if (ticketType == "Standard")
            {
                price = ticketsCnt * 110.10;
            }
            else if (ticketType == "Premium")
            {
                price = ticketsCnt * 160.66;
            }
            else if (ticketType == "VIP")
            {
                price = ticketsCnt * 400.00;
            }
        }

        if(price > 4000)
        {
            discount = price * 0.25;
            price -= discount;
        }
        else if(price > 2500 && price <= 4000)
        {
            discount = price * 0.10;
            price -= discount;

            if (pic == "Y")
            {
                price += (ticketsCnt * 40);
            }
        }
        else if(price < 2500)
        {
            if(pic == "Y")
            {
                price += (ticketsCnt * 40);
            }
        }

        Console.WriteLine($"{price:F2}");
    }
}