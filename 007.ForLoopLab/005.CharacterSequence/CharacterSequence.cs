//Chapter For loop - lab, Task 005
//26.11.2022, 21:24
using System;

public class CharacterSequence
{
    static void Main()
    {
        string text = Console.ReadLine();

        for(int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            Console.WriteLine(c);
        }
    }
}