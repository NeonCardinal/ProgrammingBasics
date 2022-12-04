//Chapter For loop - exercise, Task 003
//03.12.2022, 23:46
using System;
using System.Collections.Concurrent;

public class Histogram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int p1Cnt = 0;
        int p2Cnt = 0;
        int p3Cnt = 0;
        int p4Cnt = 0;
        int p5Cnt = 0;
        double p1Percent = 0.0;
        double p2Percent = 0.0;
        double p3Percent = 0.0;
        double p4Percent = 0.0;
        double p5Percent = 0.0;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number < 200)
            {
                p1Cnt++;
            }
            else if(number >= 200 && number <= 399)
            {
                p2Cnt++;
            }
            else if(number >= 400 && number <= 599)
            {
                p3Cnt++;
            }
            else if(number >= 600 && number <= 799)
            {
                p4Cnt++;
            }
            else if(number >= 800)
            {
                p5Cnt++;
            }
        }

        p1Percent = (p1Cnt * 1.0) / n * 100;
        p2Percent = (p2Cnt * 1.0) / n * 100;
        p3Percent = (p3Cnt * 1.0) / n * 100;
        p4Percent = (p4Cnt * 1.0) / n * 100;
        p5Percent = (p5Cnt * 1.0) / n * 100;

        Console.WriteLine($"{p1Percent:F2}%");
        Console.WriteLine($"{p2Percent:F2}%");
        Console.WriteLine($"{p3Percent:F2}%");
        Console.WriteLine($"{p4Percent:F2}%");
        Console.WriteLine($"{p5Percent:F2}%");
    }
}