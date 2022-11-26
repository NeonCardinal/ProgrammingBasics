//Chapter Conditional statements advanced - exercise, Task 006
//26.11.2022, 19:28
using System;

public class OperationsBetweenNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();

        if(symbol == "+")
        {
            int result = firstNumber + secondNumber;

            if(result % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - even");
            }
            else
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - odd");
            }
        }
        else if(symbol == "-")
        {
            int result = firstNumber - secondNumber;

            if (result % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - even");
            }
            else
            {
                Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - odd");
            }
        }
        else if(symbol == "*")
        {
            int result = firstNumber * secondNumber;

            if (result % 2 == 0)
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - even");
            }
            else
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - odd");
            }
        }
        else if(symbol == "/")
        {
            if(secondNumber == 0)
            {
                Console.WriteLine($"Cannot divide {firstNumber} by zero");
            }
            else
            {
                double result = firstNumber / (secondNumber * 1.00);
                Console.WriteLine($"{firstNumber} / {secondNumber} = {result:F2}");
            }
        }
        else if(symbol == "%")
        {
            if (secondNumber == 0)
            {
                Console.WriteLine($"Cannot divide {firstNumber} by zero");
            }
            else
            {
                double result = firstNumber % secondNumber;
                Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
            }
        }
    }
}