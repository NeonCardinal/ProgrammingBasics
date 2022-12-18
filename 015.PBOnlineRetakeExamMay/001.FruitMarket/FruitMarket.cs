//Chapter PB online ratake exam May 2019, Task 001
//16.12.2022, 00:09
using System;

public class FruitMarket
{
    static void Main()
    {
        double strawberryPrice = double.Parse(Console.ReadLine());
        double bananaKilos = double.Parse(Console.ReadLine());
        double orangeKilos = double.Parse(Console.ReadLine());
        double raspberryKilos = double.Parse(Console.ReadLine());
        double strawberryKillos = double.Parse(Console.ReadLine());

        double raspberryPrice = strawberryPrice * 0.50;
        double orangePrice = raspberryPrice * 0.60;
        double bananaPrice = raspberryPrice * 0.20;

        double total = strawberryKillos * strawberryPrice + bananaKilos * bananaPrice +
            orangeKilos * orangePrice + raspberryKilos * raspberryPrice;

        Console.WriteLine($"{total:F2}");
    }
}