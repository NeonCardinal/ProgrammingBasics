//Chapter While loop - exercise, Task 001
//08.12.2022, 19:30
using System;

public class OldBooks
{
    static void Main()
    {
        int bookCounter = 0;
        string bookName = Console.ReadLine();

        while(true)
        {
            string text = Console.ReadLine();

            if(text == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
                break;
            }

            if(text == bookName)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
                break;
            }
            bookCounter++;
        }
    }
}