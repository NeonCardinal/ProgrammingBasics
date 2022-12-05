//Chapter While loop - lab, Task 003
//05.12.2022, 23:35
using System;

public class SumNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        while(sum < number)
        {
            sum += int.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}