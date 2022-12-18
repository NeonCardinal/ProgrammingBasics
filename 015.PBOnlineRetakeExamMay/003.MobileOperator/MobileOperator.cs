//Chapter PB online retake exam May 2019, Task 003
//16.12.2022, 00:52
using System;

public class MobileOperator
{
    static void Main()
    {
        string term = Console.ReadLine().ToLower();
        string type = Console.ReadLine().ToLower();
        string internet = Console.ReadLine().ToLower();
        int months = int.Parse(Console.ReadLine());

        double price = 0.00;

        if(term == "one")
        {
            if(type == "small")
            {
                price = 9.98;
            }
            else if(type == "middle")
            {
                price = 18.99;
            }
            else if(type == "large")
            {
                price = 25.98;
            }
            else if(type == "extralarge")
            {
                price = 35.99;
            }
        }
        else if(term == "two")
        {
            if (type == "small")
            {
                price = 8.58;
            }
            else if (type == "middle")
            {
                price = 17.09;
            }
            else if (type == "large")
            {
                price = 23.59;
            }
            else if (type == "extralarge")
            {
                price = 31.79;
            }
        }

        if(internet == "yes")
        {
            if(price <= 10)
            {
                price += 5.50;
            }
            else if(price > 10 && price <= 30)
            {
                price += 4.35;
            }
            else if(price > 30)
            {
                price += 3.85;
            }
        }

        double totalOne = price * months;
        double totalTwo = price * months;

        if(term == "two")
        {
            double discount = totalTwo * 0.0375;
            totalTwo -= discount;
            Console.WriteLine($"{totalTwo:F2} lv.");
        }
        else
        {
            Console.WriteLine($"{totalOne:F2} lv.");
        }
    }
}