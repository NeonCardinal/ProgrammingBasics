//Chapter PB online exam April 2019, Task 001
//16.12.2022, 20:25
using System;

public class OscarsCeremony
{
    static void Main()
    {
        int rent = int.Parse(Console.ReadLine());

        double statuettesPrice = rent * 0.70;
        double cateringPrice = statuettesPrice * 0.85;
        double soundPrice = cateringPrice / 2;

        double total = rent + statuettesPrice + cateringPrice + soundPrice;

        Console.WriteLine($"{total:F2}");
    }
}