//Chapter For loop - lab, Task 004
//26.11.2022, 21:21
using System;

public class EvenPowersOfTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i <= n; i += 2)
        {
            Console.WriteLine(Math.Pow(2, i));
        }
    }
}