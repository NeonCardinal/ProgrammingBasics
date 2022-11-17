//Chapter First steps in programming - exercise, Task 003
//17.11.2022, 23:31
using System;

public class DepositCalculator
{
    static void Main()
    {
        //Read input
        double deposit = double.Parse(Console.ReadLine());
        int period = int.Parse(Console.ReadLine());
        double add = double.Parse(Console.ReadLine());

        //Calculations
        double total = deposit + period * ((deposit * (add / 100)) / 12);

        //Print result on the console
        Console.WriteLine(total);
    }
}