//Chapter Conditional statements advanced - lab, Task 008
//23.11.2022, 22:12
using System;

public class CinemaTicket
{
    static void Main()
    {
        string day = Console.ReadLine();

        switch(day)
        {
            case "Monday":
                Console.WriteLine(12);
                break;
            case "Tuesday":
                Console.WriteLine(12);
                break;
            case "Wednesday":
                Console.WriteLine(14);
                break;
            case "Thursday":
                Console.WriteLine(14);
                break;
            case "Friday":
                Console.WriteLine(12);
                break;
            case "Saturday":
                Console.WriteLine(16);
                break;
            case "Sunday":
                Console.WriteLine(16);
                break;
            default:
                break;
        }
    }
}