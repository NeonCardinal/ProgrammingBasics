//Chapter PB exam April 2019, Task 010;
//15.12.2022, 23:13
using System;

public class EasterBake
{
    static void Main()
    {
        int kozunaci = int.Parse(Console.ReadLine());

        int flourTotalGrams = 0;
        int sugarTotalGrams = 0;
        int maxFlour = int.MinValue;
        int maxSugar = int.MinValue;

        for(int i = 0; i < kozunaci; i++)
        {
            int sugarGrams = int.Parse(Console.ReadLine());
            int flourGrams = int.Parse(Console.ReadLine());

            flourTotalGrams += flourGrams;
            sugarTotalGrams += sugarGrams;

            if(flourGrams >= maxFlour)
            {
                maxFlour = flourGrams;
            }
            if(sugarGrams >= maxSugar)
            {
                maxSugar = sugarGrams;
            }
        }

        int flourPackets = (int)Math.Ceiling(flourTotalGrams / 750.0);
        int sugarPackets = (int)Math.Ceiling(sugarTotalGrams / 950.0);

        Console.WriteLine($"Sugar: {sugarPackets}");
        Console.WriteLine($"Flour: {flourPackets}");
        Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
    }
}