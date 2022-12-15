//Chapter PB exam March 2019, Task 005
//14.12.2022, 00:28
using System;

public class Gymnastics
{
    static void Main()
    {
        string country = Console.ReadLine();
        string type = Console.ReadLine();

        double points = 0.00;
        double neededPoints = 0.00;
        double percent = 0.00;

        if(country == "Russia")
        {
            if(type == "ribbon")
            {
                points = 9.100 + 9.400;
                neededPoints = 20 - points;
                percent = Math.Abs((points / 20.0) * 100 - 100);
            }
            else if(type == "hoop")
            {
                points = 9.300 + 9.800;
                neededPoints = 20 - points;
                percent = Math.Abs((points / 20.0) * 100 - 100);
            }
            else if(type == "rope")
            {
                points = 9.600 + 9.000;
                neededPoints = 20 - points;
                percent = Math.Abs((points / 20.0) * 100 - 100);
            }
        }
        else if(country == "Bulgaria")
        {
            if(type == "ribbon")
            {
                points = 9.600 + 9.400;
                neededPoints = 20 - points;
                percent = Math.Abs((points / 20.0) * 100 - 100);
            }
            else if(type == "hoop")
            {
                points = 9.550 + 9.750;
                neededPoints = 20 - points;
                percent = Math.Abs((points / 20.0) * 100 - 100);
            }
            else if(type == "rope")
            {
                points = 9.500 + 9.400;
                neededPoints = 20 - points;
                percent = Math.Abs((points / 20.0) * 100 - 100);
            }
        }
        else if(country == "Italy")
        {
            if(type == "ribbon")
            {
                points = 9.200 + 9.500;
                neededPoints = 20 - points;
                percent = Math.Abs((points / 20.0) * 100 - 100);
            }
            else if(type == "hoop")
            {
                points = 9.450 + 9.350;
                neededPoints = 20 - points;
                percent = Math.Abs((points / 20.0) * 100 - 100);
            }
            else if(type == "rope")
            {
                points = 9.700 + 9.150;
                neededPoints = 20 - points;
                percent = Math.Abs((points / 20.0) * 100 - 100);
            }
        }

        Console.WriteLine($"The team of {country} get {points:F3} on {type}.");
        Console.WriteLine($"{percent:F2}%");
    }
}