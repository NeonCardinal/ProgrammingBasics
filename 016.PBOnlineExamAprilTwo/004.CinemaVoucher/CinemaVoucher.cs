//Chapter PB online exam April 2019, Task 003
//16.12.2022, 21:14
using System;

public class CinemaVoucher
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());

        string name = Console.ReadLine();

        int sum = 0;
        int ticketsCnt = 0;
        int othersCnt = 0;

        while(name != "End")
        {
            if(name.Length > 8)
            {
                sum = (int)name[0] + (int)name[1];

                if(sum <= value)
                {
                    value -= sum;
                    ticketsCnt++;
                }
                else
                {
                    break;
                }
            }
            else if(name.Length <= 8)
            {
                sum = (int)name[0];
                
                if(sum <= value)
                {
                    value -= sum;
                    othersCnt++;
                }
                else
                {
                    break;
                }
            }

            name = Console.ReadLine();
        }

        Console.WriteLine($"{ticketsCnt}");
        Console.WriteLine($"{othersCnt}");
    }
}