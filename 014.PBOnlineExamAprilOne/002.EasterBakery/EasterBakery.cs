//Chapter PB exam April 2019, Task 002
//15.12.2022, 20:31
using System;

public class EasterBakery
{
    static void Main()
    {
        double flourPrice = double.Parse(Console.ReadLine());
        double flourAmount = double.Parse(Console.ReadLine());
        double sugarAmount = double.Parse(Console.ReadLine());
        int eggs = int.Parse(Console.ReadLine());
        int maqCnt = int.Parse(Console.ReadLine());

        double sugarPrice = flourPrice * 0.75;
        double eggsPrice = (flourPrice * 0.10) + flourPrice;
        double maqPrice = sugarPrice * 0.20;

        double total = (flourPrice * flourAmount) + (sugarAmount * sugarPrice) + (eggs * eggsPrice) +
            (maqCnt * maqPrice);

        Console.WriteLine($"{total:F2}");
    }
}