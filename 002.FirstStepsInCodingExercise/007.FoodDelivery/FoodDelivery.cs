//Chapter First steps in programming - exercise, Task 007
//17.11.2022, 23:53
using System;

public class FoodDelivery
{
    static void Main()
    {
        //Read input
        int chickenCounter = int.Parse(Console.ReadLine());
        int fishCounter = int.Parse(Console.ReadLine());
        int vegeterianCounter = int.Parse(Console.ReadLine());

        //Calculations
        double priceForChicken = chickenCounter * 10.35;
        double priceForFish = fishCounter * 12.40;
        double priceForVegeterian = vegeterianCounter * 8.15;
        double price = priceForChicken + priceForFish + priceForVegeterian;
        double desertPrice = price * 0.20;
        double total = price + desertPrice + 2.50;

        //Print result on the console
        Console.WriteLine(total);
    }
}