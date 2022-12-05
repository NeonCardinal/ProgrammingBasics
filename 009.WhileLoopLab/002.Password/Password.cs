//Chapter While loop - lab, Task 002
//05.12.2022, 23:30
using System;

public class Password
{
    static void Main()
    {
        string user = Console.ReadLine();
        string password = Console.ReadLine();

        string input = Console.ReadLine();

        while(input != password)
        {
            input = Console.ReadLine();
        }

        Console.WriteLine($"Welcome {user}!");
    }
}