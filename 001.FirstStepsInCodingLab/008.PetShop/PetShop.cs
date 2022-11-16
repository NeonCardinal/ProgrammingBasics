//Chapter First steps in programmin - lab, Task 008
//17.11.2022, 00:09
using System;

public class PetShop
{
    static void Main()
    {
        //Read input
        int dogFoodPackets = int.Parse(Console.ReadLine());
        int catFoodPackets = int.Parse(Console.ReadLine());

        //Calculations
        double total = dogFoodPackets * 2.50 + catFoodPackets * 4;

        //Print result on the console
        Console.WriteLine($"{total} lv.");
    }
}