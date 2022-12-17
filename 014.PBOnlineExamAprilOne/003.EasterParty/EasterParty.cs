//Chapter PB exam April 2019, Task 003
//15.12.2022, 20:41
using System;

public class EasterParty
{
    static void Main()
    {
        int guestsCount = int.Parse(Console.ReadLine());
        double pricePerPerson = double.Parse(Console.ReadLine());
        double budjet = double.Parse(Console.ReadLine());

        double discount = 0.00;

        if(guestsCount >= 10 && guestsCount <= 15)
        {
            discount = pricePerPerson * 0.15;
            pricePerPerson -= discount;
        }
        else if(guestsCount > 15 && guestsCount <= 20)
        {
            discount = pricePerPerson * 0.20;
            pricePerPerson -= discount;
        }
        else if(guestsCount > 20)
        {
            discount = pricePerPerson * 0.25;
            pricePerPerson -= discount;
        }

        double cakePrice = budjet * 0.10;
        double total = guestsCount * pricePerPerson + cakePrice;

        if(total <= budjet)
        {
            Console.WriteLine($"It is party time! {Math.Abs(total - budjet):F2} leva left.");
        }
        else
        {
            Console.WriteLine($"No party! {Math.Abs(budjet - total):F2} leva needed.");
        }
    }
}