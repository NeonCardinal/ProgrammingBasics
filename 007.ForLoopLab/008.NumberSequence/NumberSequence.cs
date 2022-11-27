﻿using System;

public class NumberSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number >= max)
            {
                max = number;
            }
            if(number <= min)
            {
                min = number;
            }
        }

        Console.WriteLine($"Max number: {max}");
        Console.WriteLine($"Min number: {min}");
    }
}