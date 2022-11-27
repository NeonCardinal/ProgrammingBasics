//Chapter For loop - lab, Task 002
//26.11.2022, 21:16
using System;

public class NumbersFromNToOne
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = n; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
