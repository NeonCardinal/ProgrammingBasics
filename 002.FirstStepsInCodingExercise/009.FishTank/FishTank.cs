//Chapter First steps in programmin - exercise, Task 009
//18.11.2022, 00:09
using System;

public class FishTank
{
    static void Main()
    {
        //Read input
        int len = int.Parse(Console.ReadLine());
        int widht = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());

        //Calculations
        double volume = (len * widht * height) * 0.001;
        double takenArea = volume * (percent / 100.0);
        double total = volume - takenArea;

        //Print result on the console
        Console.WriteLine(total);
    }
}