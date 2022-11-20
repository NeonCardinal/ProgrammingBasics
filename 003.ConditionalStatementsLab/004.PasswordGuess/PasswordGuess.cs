//Chapter Conditional statements - lab, Task 004
//18.11.2022, 01:25
using System;

public class PasswordGuess
{
    static void Main()
    {
        //Read input
        string password = Console.ReadLine();

        //Logic & result
        if (password == "s3cr3t!P@ssw0rd")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}