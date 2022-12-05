//Chapter While loop - lab, Task 004
//05.12.2022, 23:40
using System;

public class Sequence
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int k = 1;

        while(k <= number)
        {
            Console.WriteLine(k);

            k = k * 2 + 1;
        }
    }
}