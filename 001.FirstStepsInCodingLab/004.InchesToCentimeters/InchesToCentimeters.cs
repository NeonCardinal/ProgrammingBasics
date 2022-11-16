//Chapter First steps in programmin - lab, Task 004
//16.11.2022 23.54
using System;

public class InchesToCentimeters
{
    static void Main()
    {
        //Read input
        double inches = double.Parse(Console.ReadLine());

        //Calculations
        double centimeters = inches * 2.54;

        //Printe result on the console
        Console.WriteLine(centimeters);
    }
}