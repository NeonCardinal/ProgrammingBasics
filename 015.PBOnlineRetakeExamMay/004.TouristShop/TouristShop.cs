//Chapter PB online retake exam May 2019, Task 004
//16.12.2022, 01:17
using System;

public class TouristShop
{
    static void Main()
    {
        double budjet = double.Parse(Console.ReadLine());

        double productCnt = 1;
        double sum = 0.00;

        while (true)
        {
            string product = Console.ReadLine();

            if (product == "Stop")
            {
                Console.WriteLine($"You bought {productCnt - 1} products for {sum:F2} leva.");
                break;
            }

            double price = double.Parse(Console.ReadLine());

            if(productCnt % 3 == 0)
            {
                price = price * 0.50;
            }

            if (price > budjet)
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {(price - budjet):F2} leva!");
                break;
            }
            else
            {
                productCnt++;
                sum += price;
                budjet -= price;
            }
        }
    }
}