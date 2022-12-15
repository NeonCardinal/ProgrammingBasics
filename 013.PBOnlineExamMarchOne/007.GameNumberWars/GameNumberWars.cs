//Chapter PB exam March 2019, Task 007
//15.12.2022, 18:05
using System;

public class GameNumberWars
{
    static void Main()
    {
        string firstPlayer = Console.ReadLine();
        string secondPlayer = Console.ReadLine();

        int firstPlayerScore = 0;
        int secondPlayerScore = 0;

        string command = string.Empty;

        while(true)
        {
            command = Console.ReadLine();

            if(command == "End of game")
            {
                Console.WriteLine($"{firstPlayer} has {firstPlayerScore} points");
                Console.WriteLine($"{secondPlayer} has {secondPlayerScore} points");
                break;
            }

            int firstPlayerCard = int.Parse(command);

            command = Console.ReadLine();

            int secondPlayerCard = int.Parse(command);

            if(firstPlayerCard > secondPlayerCard)
            {
                firstPlayerScore += firstPlayerCard - secondPlayerCard;
            }
            else if(secondPlayerCard > firstPlayerCard)
            {
                secondPlayerScore += secondPlayerCard - firstPlayerCard;
            }
            else if(firstPlayerCard == secondPlayerCard)
            {
                Console.WriteLine("Number wars!");

                command = Console.ReadLine();
                firstPlayerCard = int.Parse(command);
                command = Console.ReadLine();
                secondPlayerCard = int.Parse(command);

                if(firstPlayerCard > secondPlayerCard)
                {
                    Console.WriteLine($"{firstPlayer} is winner with {firstPlayerScore} points");
                }
                else if(secondPlayerCard > firstPlayerCard)
                {
                    Console.WriteLine($"{secondPlayer} is winner with {secondPlayerScore} points");
                }

                break;
            }
        }
    }
}