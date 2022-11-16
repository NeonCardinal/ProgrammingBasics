//Chapter First steps in programmin - lab, Task 007
//17.11.2022, 00:04
using System;

public class ProjectsCreation
{
    static void Main()
    {
        //Read input
        string name = Console.ReadLine();
        int projects = int.Parse(Console.ReadLine());

        //Calculations
        int neededHours = projects * 3;

        //Print result on the console
        Console.WriteLine($"The architect {name} will need {neededHours} hours to complete {projects} project/s.");
    }
}