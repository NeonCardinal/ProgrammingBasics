//Chapter PB online exam April 2019, Task 006
//18.12.2022, 15:50;
using System;

public class CinemaTickets
{
    static void Main()
    {
        string movieName = Console.ReadLine();

        int student = 0;
        int standart = 0;
        int kid = 0;

        while(movieName != "Finish")
        {
            int places = int.Parse(Console.ReadLine());
            int people = 0;

            for(int i = 0; i < places; i++)
            {
                string command = Console.ReadLine();

                if(command == "student")
                {
                    student++;
                }
                else if(command == "standard")
                {
                    standart++;
                }
                else if(command == "kid")
                {
                    kid++;
                }
                else if(command == "End")
                {
                    break;
                }

                people++;
            }

            Console.WriteLine($"{movieName} - {((people * 1.0) / places * 100):F2}% full.");

            movieName = Console.ReadLine();
        }

        int totalTickets = standart + student + kid;

        Console.WriteLine($"Total tickets: {totalTickets}");
        Console.WriteLine($"{((student * 1.0) / totalTickets * 100):F2}% student tickets.");
        Console.WriteLine($"{((standart * 1.0) / totalTickets * 100):F2}% standard tickets.");
        Console.WriteLine($"{((kid * 1.0) / totalTickets * 100):F2}% kids tickets.");
    }
}