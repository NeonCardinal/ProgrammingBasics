//Chapter For loop - exercise, Task 001
//28.11.2022, 21:57
using System;

public class NumbersEndingInSeven
{
    static void Main()
    {
        for(int i = 1; i <= 1000; i++)
        {
            if(i % 10 == 7)
            {
                Console.WriteLine(i);
            }
        }
    }
}