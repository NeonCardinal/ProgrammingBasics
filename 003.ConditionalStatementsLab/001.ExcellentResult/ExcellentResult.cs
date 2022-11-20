//Chapter Conditional statements - lab, Task 001
//18.11.2022, 01.16
using System;

public class ExcellentResult
{
    static void Main()
    {
        //Read input
        double grade = double.Parse(Console.ReadLine());

        //Logic
        if(grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
    }
}
