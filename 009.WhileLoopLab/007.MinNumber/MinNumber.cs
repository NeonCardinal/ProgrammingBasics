//Chapter While loop - lab, Task 007
//06.12.2022, 00:06
using System;

public class MinNumber
{
    static void Main()
    {
        string command = Console.ReadLine();

        int min = int.MaxValue;

        while(command != "Stop")
        {
            int number = int.Parse(command);

            if(number <= min)
            {
                min = number;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(min);
    }
}
