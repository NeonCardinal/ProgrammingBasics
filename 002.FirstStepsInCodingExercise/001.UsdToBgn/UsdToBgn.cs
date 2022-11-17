//Chapter First steps in coding - exercise, Task 001
//17.11.2022, 23:24
using System;

public class UsdToBgn
{
    static void Main()
    {
        //Read input
        double dollars = double.Parse(Console.ReadLine());

        //Calculations
        double leva = dollars * 1.79549;

        //Print result on the console
        Console.WriteLine(leva);
    }
}