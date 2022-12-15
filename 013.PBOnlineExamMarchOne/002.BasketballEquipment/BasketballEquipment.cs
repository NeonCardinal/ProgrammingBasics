//PB Exam March 2019, Task 002
//11.12.2002, 15:03
using System;

public class BasketballEquipment
{
    static void Main()
    {
        double yearTax = double.Parse(Console.ReadLine());

        double shoesPrice = yearTax * 0.60;
        double equipPrice = shoesPrice * 0.80;
        double ballPrice = equipPrice / 4;
        double accPrice = ballPrice / 5;

        double total = shoesPrice + equipPrice + ballPrice + accPrice + yearTax;

        Console.WriteLine($"{total:F2}");
    }
}