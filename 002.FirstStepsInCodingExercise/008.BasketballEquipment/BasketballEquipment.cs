//Chapter First steps in programmin - exercise, Task 008
//18.11.2022, 00:00
using System;

public class BasketballEquipment
{
    static void Main()
    {
        //Read input
        int pricePerYear = int.Parse(Console.ReadLine());

        //Calculations
        double priceForShoes = pricePerYear * 0.60;
        double pricePerEquipe = priceForShoes * 0.80;
        double priceForBall = pricePerEquipe / 4;
        double priceForAcc = priceForBall / 5;
        double total = pricePerYear + priceForShoes + pricePerEquipe + priceForBall + priceForAcc;

        //Print result on the console
        Console.WriteLine(total);
    }
}