//Chapter First steps in programming - exercise, Task 005
//17.11.2022, 23:41
using System;

public class SuppliesForSchool
{
    static void Main()
    {
        //Read input
        int penCounter = int.Parse(Console.ReadLine());
        int markerCounter = int.Parse(Console.ReadLine());
        int litters = int.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());

        //Calculations
        double priceForPens = penCounter * 5.80;
        double priceForMarkers = markerCounter * 7.20;
        double priceForLitters = litters * 1.20;
        double priceForAll = priceForPens + priceForMarkers + priceForLitters;
        double dDiscount = priceForAll * (discount / 100.0);
        priceForAll -= dDiscount;

        //Print result on the console
        Console.WriteLine(priceForAll);
    }
}