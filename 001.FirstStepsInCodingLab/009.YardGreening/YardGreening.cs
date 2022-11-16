//Chapter First steps in programming - lab, Task 009
//17.11.2022, 00:14
using System;

public class YardGreening
{
    static void Main()
    {
        //Read input
        double area = double.Parse(Console.ReadLine());

        //Calculations
        double neededMoney = area * 7.61;
        double discount = neededMoney * 0.18;
        double total = neededMoney - discount;

        //Print result on the console
        Console.WriteLine($"The final price is: {total} lv.");
        Console.WriteLine($"The discount is: {discount} lv.");
    }
}