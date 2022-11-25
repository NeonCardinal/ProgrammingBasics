//Chapter Conditional statements advanced - exercise, Task 001
//24.11.2022, 21:08
using System;

public class Cinema
{
    static void Main()
    {
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int seats = rows * cols;
        if(type == "Premiere")
        {
            Console.WriteLine($"{(seats * 12.00):F2} leva");
        }
        else if(type == "Normal")
        {
            Console.WriteLine($"{(seats * 7.50):F2} leva");
        }
        else if(type == "Discount")
        {
            Console.WriteLine($"{(seats * 5.00):F2} leva");
        }
    }
}