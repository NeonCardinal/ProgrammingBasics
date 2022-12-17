//Chapter PB exam April 2019, Task 009
//15.12.2022, 22:52
using System;

public class EasterEggs
{
    static void Main()
    {
        int eggs = int.Parse(Console.ReadLine());

        int redEggsCnt = 0;
        int orangeEggsCnt = 0;
        int blueEggsCnt = 0;
        int greenEggsCnt = 0;
        int max = int.MinValue;
        string maxColor = string.Empty;

        for(int i = 0; i < eggs; i++)
        {
            string color = Console.ReadLine();

            if(color == "red")
            {
                redEggsCnt++;
            }
            else if(color == "orange")
            {
                orangeEggsCnt++;
            }
            else if(color == "blue")
            {
                blueEggsCnt++;
            }
            else if(color == "green")
            {
                greenEggsCnt++;
            }
        }

        if(redEggsCnt >= max)
        {
            max = redEggsCnt;
            maxColor = "red";
        }
        if(orangeEggsCnt >= max)
        {
            max = orangeEggsCnt;
            maxColor = "orange";
        }
        if(blueEggsCnt >= max)
        {
            max = blueEggsCnt;
            maxColor = "blue";
        }
        if(greenEggsCnt >= max)
        {
            max = greenEggsCnt;
            maxColor = "green";
        }

        Console.WriteLine($"Red eggs: {redEggsCnt}");
        Console.WriteLine($"Orange eggs: {orangeEggsCnt}");
        Console.WriteLine($"Blue eggs: {blueEggsCnt}");
        Console.WriteLine($"Green eggs: {greenEggsCnt}");
        Console.WriteLine($"Max eggs: {max} -> {maxColor}");
    }
}