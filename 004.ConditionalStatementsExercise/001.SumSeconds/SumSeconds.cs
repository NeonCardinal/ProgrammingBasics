//Chapter Conditional statements - exercice, Task 001
//18.11.2022, 22:40
using System;

public class SumSeconds
{
    static void Main()
    {
        //Read input
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        //Logic & calculations
        int totalTime = first + second + third;
        int minutes = totalTime / 60;
        int seconds = totalTime % 60;

        if(seconds < 10)
        {
            Console.WriteLine($"{minutes}:0{seconds}");
        }
        else
        {
            Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}