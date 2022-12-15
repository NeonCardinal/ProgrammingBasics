//Chapter PB exam March 2019, Task 010
//15.12.2022, 19:15
using System;

public class FitnessCenter
{
    static void Main()
    {
        int visitorsCnt = int.Parse(Console.ReadLine());

        int backCnt = 0;
        int chestCnt = 0;
        int legsCnt = 0;
        int absCnt = 0;
        int shakeCnt = 0;
        int barCnt = 0;
        int workoutCnt = 0;
        int proteinCnt = 0;
        double percentWorkout = 0.00;
        double percentProtein = 0.00;

        for(int i = 0; i < visitorsCnt; i++)
        {
            string cmd = Console.ReadLine();

            if(cmd == "Back")
            {
                backCnt++;
            }
            else if(cmd == "Chest")
            {
                chestCnt++;
            }
            else if(cmd == "Legs")
            {
                legsCnt++;
            }
            else if(cmd == "Abs")
            {
                absCnt++;
            }
            else if(cmd == "Protein shake")
            {
                shakeCnt++;
            }
            else if(cmd == "Protein bar")
            {
                barCnt++;
            }
        }

        workoutCnt = backCnt + chestCnt + legsCnt + absCnt;
        proteinCnt = shakeCnt + barCnt;
        percentWorkout = workoutCnt * 1.0 / visitorsCnt * 100;
        percentProtein = proteinCnt * 1.0 / visitorsCnt * 100;

        Console.WriteLine($"{backCnt} - back");
        Console.WriteLine($"{chestCnt} - chest");
        Console.WriteLine($"{legsCnt} - legs");
        Console.WriteLine($"{absCnt} - abs");
        Console.WriteLine($"{shakeCnt} - protein shake");
        Console.WriteLine($"{barCnt} - protein bar");
        Console.WriteLine($"{percentWorkout:F2}% - work out");
        Console.WriteLine($"{percentProtein:F2}% - protein");
    }
}