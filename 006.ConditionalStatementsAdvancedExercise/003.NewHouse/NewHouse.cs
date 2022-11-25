//Chapter Conditional statements advanced - exercise, Task 003
//24.11.2022, 22:01
using System;

public class NewHouse
{
    static void Main()
    {
        string flowersType = Console.ReadLine();
        int flowersCounter = int.Parse(Console.ReadLine());
        double budjet = double.Parse(Console.ReadLine());

        double discount = 0;
        double totalPrice = 0.0;
        if(flowersType == "Roses")
        {
            totalPrice = flowersCounter * 5.00;

            if(flowersCounter > 80)
            {
                discount = totalPrice * 0.10;
                totalPrice -= discount;
            }
        }
        else if(flowersType == "Dahlias")
        {
            totalPrice = flowersCounter * 3.80;

            if (flowersCounter > 90)
            {
                discount = totalPrice * 0.15;
                totalPrice -= discount;
            }
        }
        else if(flowersType == "Tulips")
        {
            totalPrice = flowersCounter * 2.80;

            if(flowersCounter > 80)
            {
                discount = totalPrice * 0.15;
                totalPrice -= discount;
            }
        }
        else if(flowersType == "Narcissus")
        {
            totalPrice = flowersCounter * 3.00;

            if(flowersCounter < 120)
            {
                double add = totalPrice * 0.15;
                totalPrice += add;
            }
        }
        else if(flowersType == "Gladiolus")
        {
            totalPrice = flowersCounter * 2.50;

            if(flowersCounter < 80)
            {
                double add = totalPrice * 0.20;
                totalPrice += add;
            }
        }

        if(totalPrice <= budjet)
        {
            Console.WriteLine($"Hey, you have a great garden with {flowersCounter} {flowersType} and {(budjet - totalPrice):F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {(totalPrice - budjet):F2} leva more.");
        }
    }
}