//Chapter First steps in coding - exercise
//17.11.2022, 23:27
using System;

public class RadiansToDegrees
{
    static void Main()
    {
        //Read input
        double radians = double.Parse(Console.ReadLine());

        //Calculations
        double degrees = radians * 180 / Math.PI;

        //Print result on the console
        Console.WriteLine(degrees);
    }
}