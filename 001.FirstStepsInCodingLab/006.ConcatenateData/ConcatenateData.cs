//Chapter First steps in programmin - lab, Task 006
//17.11.2022, 00:00
using System;

public class ConcatenateData
{
    static void Main()
    {
        //Read input
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string town = Console.ReadLine();

        //Print result on the console
        Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
    }
}