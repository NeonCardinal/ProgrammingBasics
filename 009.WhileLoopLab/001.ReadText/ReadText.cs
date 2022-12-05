//Chapter While loop - lab, Task 001
//05.12.2022, 23:28
using System;

public class ReadText
{
    static void Main()
    {
        string text = Console.ReadLine();

        while(text != "Stop")
        {
            Console.WriteLine(text);

            text = Console.ReadLine();
        }
    }
}