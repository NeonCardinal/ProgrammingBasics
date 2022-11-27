//Chapter For loop - lab, Task 009
//26.11.2022, 21:40
using System;

public class LeftAndRightSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            leftSum += number;
        }

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            rightSum += number;
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}