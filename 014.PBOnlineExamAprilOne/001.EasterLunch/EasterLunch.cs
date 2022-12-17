//Chapter PB exam April 2019, Task 001
//15.12.2022, 20:24
using System;

public class EasterLunch
{
    static void Main()
    {
        int kozunakCnt = int.Parse(Console.ReadLine());
        int eggsCnt = int.Parse(Console.ReadLine());
        int cakesCnt = int.Parse(Console.ReadLine());

        double price = kozunakCnt * 3.20 + eggsCnt * 4.35 + cakesCnt * 5.40;
        double dyePrice = eggsCnt * 12 * 0.15;
        double total = price + dyePrice;

        Console.WriteLine($"{total:F2}");
    }
}