//PB Online retake exam May 2019, Task 002
//16.12.2022, 00:42
using System;

public class Safari
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());
        double neededGas = double.Parse(Console.ReadLine());
        string day = Console.ReadLine();

        double price = neededGas * 2.10 + 100;
        double discount = 0.00;

        if(day == "Saturday")
        {
            discount = price * 0.10;
        }
        else if(day == "Sunday")
        {
            discount = price * 0.20;
        }

        price -= discount;

        if(price <= budjet)
        {
            Console.WriteLine($"Safari time! Money left: {(budjet - price):F2} lv.");
        }
        else
        {
            Console.WriteLine($"Not enough money! Money needed: {(price - budjet):F2} lv.");
        }
    }
}