//Chapter Fist steps in programming - lab, Task 003
//16.11.2022 23.51
using System;

public class RectangleArea
{
    static void Main()
    {
        //Read input
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        //Calculations
        int area = a * b;

        //Print result on the console
        Console.WriteLine(area);
    }
}