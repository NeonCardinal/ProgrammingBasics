//Chapter Conditional statements advanced - lab, Task 003
//23.11.2022, 00:19
using System;

public class AnimalType
{
    static void Main()
    {
        string animal = Console.ReadLine();

        switch(animal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}