﻿//Chapter PB exam April 2019, Task 012
//15.12.2022, 23:32
using System;

public class EasterDecoration
{
    static void Main()
    {
        int clients = int.Parse(Console.ReadLine());
        double totalPrice = 0.0;

        for (int i = 0; i < clients; i++)
        {
            string command = Console.ReadLine();
            double price = 0.0;
            int productCount = 0;
            while ("Finish" != command)
            {
                productCount++;
                switch (command)
                {
                    case "basket":
                        price += 1.50;
                        break;
                    case "wreath":
                        price += 3.80;
                        break;
                    case "chocolate bunny":
                        price += 7;
                        break;
                }
                command = Console.ReadLine();
            }
            if (productCount % 2 == 0)
            {
                double discount = price * 0.2;
                price -= discount;
            }
            Console.WriteLine($"You purchased {productCount} items for {price:F2} leva.");
            totalPrice += price;
        }
        Console.WriteLine($"Average bill per client is: {totalPrice / clients:F2} leva.");
    }
}