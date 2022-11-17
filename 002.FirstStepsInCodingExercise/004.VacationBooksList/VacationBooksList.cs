//Chapter First steps in programming - exercise, Task 004
//17.11.2022, 23:36
using System;

public class VacationBooksList
{
    static void Main()
    {
        //Read input
        int pagesCounter = int.Parse(Console.ReadLine());
        int pagesPerHour = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        //Calculations
        int totalTimeForBook = pagesCounter / pagesPerHour;
        int neededHours = totalTimeForBook / days;

        //Print result on the console
        Console.WriteLine(neededHours);
    }
}