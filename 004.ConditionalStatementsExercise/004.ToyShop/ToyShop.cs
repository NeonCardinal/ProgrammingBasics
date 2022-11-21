//Chapter Conditional statements, Task 004
//21.11.2022, 23:42
using System;

public class ToyShop
{
    static void Main()
    {
        //Read input
        double priceForVacantion = double.Parse(Console.ReadLine());
        int puzzleCounter = int.Parse(Console.ReadLine());
        int mupperCounter = int.Parse(Console.ReadLine());
        int teddyBearCounter = int.Parse(Console.ReadLine());
        int minionsCounter = int.Parse(Console.ReadLine());
        int trucksCounter = int.Parse(Console.ReadLine());

        //Logic & calculations
        int toyCounter = puzzleCounter + mupperCounter + teddyBearCounter + minionsCounter + trucksCounter;
        double discount = 0.0;
        double income = puzzleCounter * 2.60 + mupperCounter * 3.00 + teddyBearCounter * 4.10 +
            minionsCounter * 8.20 + trucksCounter * 2.00;

        if(toyCounter >= 50)
        {
            discount = income * 0.25;
            income -= discount;
        }

        double rent = income * 0.10;
        income -= rent;

        if(income >= priceForVacantion)
        {
            Console.WriteLine($"Yes! {(income - priceForVacantion):F2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {(priceForVacantion - income):F2} lv needed.");
        }
    }
}