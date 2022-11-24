//Chapter Conditional statements advanced - lab, Task 004
//23.11.2022, 00:23
using System;

public class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        if(gender == "m")
        {
            if(age < 16)
            {
                Console.WriteLine("Master");
            }
            else if(age >= 16)
            {
                Console.WriteLine("Mr.");
            }
        }
        else if(gender == "f")
        {
            if(age < 16)
            {
                Console.WriteLine("Miss");
            }
            else if(age >= 16)
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}