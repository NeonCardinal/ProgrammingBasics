//Chapter For loop - lab, Task 006
//26.11.2022, 21:26
using System;

public class VowelsSum
{
    static void Main()
    {
        string text = Console.ReadLine();

        int sum = 0;

        for(int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if(c == 'a')
            {
                sum += 1;
            }
            else if(c == 'e')
            {
                sum += 2;
            }
            else if(c == 'i')
            {
                sum += 3;
            }
            else if(c == 'o')
            {
                sum += 4;
            }
            else if(c == 'u')
            {
                sum += 5;
            }
        }

        Console.WriteLine(sum);
    }
}