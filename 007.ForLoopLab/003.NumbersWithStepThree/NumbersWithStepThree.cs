//Chapter For loop - lab, Task 003
//26.11.2022, 21:18
using System;

public class NumbersWithStepThree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}