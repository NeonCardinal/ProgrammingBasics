//Chapter PB exam March 2019, Task 008
//15.12.2022, 18:42
using System;

public class Darts
{
    static void Main()
    {
        string playerName = Console.ReadLine();

        int secCnt = 0;
        int unsecCnt = 0;
        int startPoints = 301;

        string command = string.Empty;

        while(true)
        {
            command = Console.ReadLine();

            if(command == "Retire")
            {
                Console.WriteLine($"{playerName} retired after {unsecCnt} unsuccessful shots.");
                break;
            }

            string type = command;
            command = Console.ReadLine();
            int points = int.Parse(command);

            if(type == "Single")
            {
                if(points <= startPoints)
                {
                    secCnt++;
                    startPoints -= points;
                }
                else
                {
                    unsecCnt++;
                }
            }
            else if(type == "Double")
            {
                points *= 2;

                if(points <= startPoints)
                {
                    secCnt++;
                    startPoints -= points;
                }
                else
                {
                    unsecCnt++;
                }
            }
            else if(type == "Triple")
            {
                points *= 3;

                if(points <= startPoints)
                {
                    secCnt++;
                    startPoints -= points;
                }
                else
                {
                   unsecCnt++;
                }
            }

            if(startPoints == 0)
            {
                Console.WriteLine($"{playerName} won the leg with {secCnt} shots.");
                break;
            }
        }
    }
}