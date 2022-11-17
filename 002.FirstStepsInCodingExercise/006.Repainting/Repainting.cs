//Chapter First steps in programmin - exercise, Task 006
//17.11.2022, 23:49
using System;

public class Repainting
{
    static void Main()
    {
        //Read input
        int nylon = int.Parse(Console.ReadLine());
        int dye = int.Parse(Console.ReadLine());
        int litters = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());

        //Calculations
        nylon += 2;
        double extraDye = dye + (dye * 0.10);
        double priceForDye = extraDye * 14.50;
        double priceForNylon = nylon * 1.50;
        double priceForLitters = litters * 5.00;
        double totalPrice = priceForDye + priceForLitters + priceForNylon + 0.40;
        double priceForWork = (totalPrice * 0.30) * hours;
        double total = totalPrice + priceForWork;

        //Print result on the console
        Console.WriteLine(total);
    }
}