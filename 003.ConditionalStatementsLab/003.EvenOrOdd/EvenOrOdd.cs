//Chapter Conditional statements - lab, Task 003
//18.11.2022, 01:23
using System;

public class EvenOrOdd
{
    static void Main()
    {
        //Read input
        int number = int.Parse(Console.ReadLine());

        //Logic and result
        if(number % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}