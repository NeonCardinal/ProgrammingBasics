//PB Exam March 2019, Task 003
//14.12.2022, 00:06
using System;

public class Skeleton
{
    static void Main()
    {
        int controlMinutes = int.Parse(Console.ReadLine());
        int controlSeconds = int.Parse(Console.ReadLine());
        double len = double.Parse(Console.ReadLine());
        int secondPerOnehundredMeters = int.Parse(Console.ReadLine());

        int controlTotalSeconds = controlMinutes * 60 + controlSeconds;
        double timeSlowed = len / 120;
        double slowed = timeSlowed * 2.5;
        double marinsTime = (len / 100) * secondPerOnehundredMeters - slowed;

        if(marinsTime <= controlTotalSeconds)
        {
            Console.WriteLine("Marin Bangiev won an Olympic quota!");
            Console.WriteLine($"His time is {marinsTime:F3}.");
        }
        else
        {
            Console.WriteLine($"No, Marin failed! He was {(marinsTime - controlTotalSeconds):F3} second slower.");
        }
    }
}
