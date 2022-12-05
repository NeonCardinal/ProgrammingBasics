//Chapter While loop - lab, Task 006
//06.12.2022, 00:02
using System;

public class MaxNumber
{
    static void Main()
    {
        string command = Console.ReadLine();

        int max = int.MinValue;

        while(command != "Stop")
        {
            int number = int.Parse(command);

            if(number >= max)
            {
                max = number;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(max);
    }
}