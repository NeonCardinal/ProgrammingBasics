//Chapter Conditional statements - lab, Task 002
//18.11.2022, 01:19
using System;

public class GreaterNumber
{
    static void Main()
    {
        //Read input
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        //Logic and result
        if(a >= b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}
