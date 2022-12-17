//Chapter PB exam Aplir 2019, Task 006
//15.12.2022, 21:32
using System;
using System.Reflection;

public class PaintingEggs
{
    static void Main()
    {
        string type = Console.ReadLine();
        string color = Console.ReadLine();
        int pieces = int.Parse(Console.ReadLine());

        double price = 0.00;
        double expence = 0.00;

        if(type == "Large")
        {
            if(color == "Red")
            {
                price = pieces * 16.00;
            }
            else if(color == "Green")
            {
                price = pieces * 12.00;
            }
            else if(color == "Yellow")
            {
                price = pieces * 9.00;
            }
        }
        else if(type == "Medium")
        {
            if(color == "Red")
            {
                price = pieces * 13.00;
            }
            else if(color == "Green")
            {
                price = pieces * 9.00;
            }
            else if(color == "Yellow")
            {
                price = pieces * 7.00;
            }
        }
        else if(type == "Small")
        {
            if(color == "Red")
            {
                price = pieces * 9.00;
            }
            else if(color == "Green")
            {
                price = pieces * 8.00;
            }
            else if(color == "Yellow")
            {
                price = pieces * 5.00;
            }
        }

        expence = price * 0.35;
        price -= expence;

        Console.WriteLine($"{price:F2} leva.");
    }
}