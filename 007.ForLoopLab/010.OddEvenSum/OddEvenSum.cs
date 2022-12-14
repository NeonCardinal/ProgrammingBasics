//Chapter For loop - lab, Task 010
//26.11.2022, 21:42
using System;

public class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int evenSum = 0;
        int oddSum = 0;

        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {evenSum}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}