//Chapter PB exam April 2019, Task 004
//15.12.2022, 20:59
using System;

public class EasterGuests
{
    static void Main()
    {
        int guestCount = int.Parse(Console.ReadLine());
        int budjet = int.Parse(Console.ReadLine());

        int kozunakCnt = (int)Math.Ceiling(guestCount / 3.00);
        int eggsCnt = guestCount * 2;
        double price = kozunakCnt * 4.00 + eggsCnt * 0.45;

        if(price <= budjet)
        {
            Console.WriteLine($"Lyubo bought {kozunakCnt} Easter bread and {eggsCnt} eggs.");
            Console.WriteLine($"He has {(budjet - price):F2} lv. left.");
        }
        else
        {
            Console.WriteLine("Lyubo doesn't have enough money.");
            Console.WriteLine($"He needs {(price - budjet):F2} lv. more.");
        }
    }
}