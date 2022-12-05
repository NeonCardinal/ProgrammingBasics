//Chapter While loop - lab, Task 005
//05.12.2022, 23:45
using System;

public class AccountBalance
{
    static void Main()
    {
        string command = Console.ReadLine();
        
        double total = 0.0;

        while (command != "NoMoreMoney")
        {
            double add = double.Parse(command);

            if(add <= 0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }
            else
            {
                Console.WriteLine($"Increase: {add:F2}");
                total += add;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"Total: {total:F2}");
    }
}