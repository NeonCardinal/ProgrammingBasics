//Chapter Conditional statements - exercise, Task 002
//19.11.2022, 00:18
using System;

public class BonusScore
{
    static void Main()
    {
        //Read input
        int number = int.Parse(Console.ReadLine());

        //Logic & result
        double bonus = 0;

        if(number <= 100)
        {
            bonus += 5;
        }
        else if(number > 100 && number <= 1000)
        {
            bonus += number * 0.20;
        }
        else if(number > 1000)
        {
            bonus += number * 0.10;
        }

        if(number % 2 == 0)
        {
            bonus += 1;
        }
        if(number % 10 == 5)
        {
            bonus += 2;
        }

        Console.WriteLine(bonus);
        Console.WriteLine(number + bonus);
    }
}