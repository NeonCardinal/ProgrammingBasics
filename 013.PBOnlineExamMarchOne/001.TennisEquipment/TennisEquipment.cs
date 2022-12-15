//PB Exam March 2019, Task 001
//11.12.2022, 12:49
using System;

public class TennisEquipment
{
    static void Main()
    {
        double tennisRaquetPrice = double.Parse(Console.ReadLine());
        int tennisRaquetCnt = int.Parse(Console.ReadLine());
        int shoesCnt = int.Parse(Console.ReadLine());

        double shoesPrice = tennisRaquetPrice / 6;
        double totalPriceForRaquet = tennisRaquetPrice * tennisRaquetCnt;
        double totalPriceForShoes = shoesPrice * shoesCnt;
        double thingsPrice = (totalPriceForRaquet + totalPriceForShoes) * 0.20;
        double total = thingsPrice + totalPriceForRaquet + totalPriceForShoes;

        double jocovic = total / 8;
        double sponsors = total * 7 / 8;

        Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(jocovic)}");
        Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsors)}");
    }
}