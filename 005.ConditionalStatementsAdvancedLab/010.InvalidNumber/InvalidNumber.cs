//Chapter Conditional statemens advanced - lab, Task 010
//23.11.2022, 22:39
using System;

public class InvalidNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isInvalid = (number < 100 || number > 200) && number != 0;

        if (isInvalid)
        {
            Console.WriteLine("invalid");
        }
    }
}
