//Chapter Conditional statements advanced - lab, Task 007
//23.11.2022, 22:00
using System;

public class WorkingHours
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        string day = Console.ReadLine();

        if((hours < 10 || hours > 18) || day == "Sunday")
        {
            Console.WriteLine("closed");
        }
        else
        {
            Console.WriteLine("open");
        }
    }
}