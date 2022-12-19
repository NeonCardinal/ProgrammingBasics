//Chapter PB online exam April 2019, Task 005
//17.12.2022, 12:44
using System;

public class MovieRatings
{
    static void Main()
    {
        int movieCnt = int.Parse(Console.ReadLine());

        double maxRating = double.MinValue;
        double minRating = double.MaxValue;
        double average = 0.00;
        string highest = string.Empty;
        string lowest = string.Empty;

        double sum = 0.00;

        for(int i = 0; i < movieCnt; i++)
        {
            string movieName = Console.ReadLine();
            double rating = double.Parse(Console.ReadLine());

            if(rating > maxRating)
            {
                maxRating = rating;
                highest = movieName;
            }
            if(rating < minRating)
            {
                minRating = rating;
                lowest = movieName;
            }

            sum += rating;
        }

        average = sum / movieCnt;

        Console.WriteLine($"{highest} is with highest rating: {maxRating:F1}");
        Console.WriteLine($"{lowest} is with lowest rating: {minRating:F1}");
        Console.WriteLine($"Average rating: {average:F1}");
    }
}