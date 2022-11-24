//Chapter Conditional statements advanced - lab, Task 006
//23.11.2022, 20:07
using System;

public class NumberInRange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if(number >= -100 && number <= 100 && number != 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}