//Chapter For loop - exercise, Task 002
//28.11.2022, Task 002
using System;

public class HalfSumElement
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int max =  int.MinValue;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            sum += number;

            if(number > max)
            {
                max = number;
            }
        }

        int sumWithoutNumber = sum - max;

        if(max == sumWithoutNumber)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = " + max);
        }
        else
        {
            int diff = Math.Abs(max - sumWithoutNumber);
            Console.WriteLine("No");
            Console.WriteLine("Diff = " + diff);
        }
    }
}