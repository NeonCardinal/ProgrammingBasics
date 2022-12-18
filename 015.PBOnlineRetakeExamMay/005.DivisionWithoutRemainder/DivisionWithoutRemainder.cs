//Chapter PB online retake exam May 2019, Task 005
//16.12.2022, 10:56
using System;

public class DivisionWithoutRemainder
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int p1Cnt = 0;
        int p2Cnt = 0;
        int p3Cnt = 0;
        double P1Percnet = 0.00;
        double p2Percent = 0.00;
        double p3Percent = 0.00;

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {
                p1Cnt++;
            }
            if(number % 3 == 0)
            {
                p2Cnt++;
            }
            if(number % 4 == 0)
            {
                p3Cnt++;
            }
        }

        P1Percnet = ((p1Cnt * 1.0) / n) * 100;
        p2Percent = ((p2Cnt * 1.0) / n) * 100;
        p3Percent = ((p3Cnt * 1.0) / n) * 100;

        Console.WriteLine($"{P1Percnet:F2}%");
        Console.WriteLine($"{p2Percent:F2}%");
        Console.WriteLine($"{p3Percent:F2}%");
    }
}