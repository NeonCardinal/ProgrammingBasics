//Chapter Conditional statements advanced - lab, Task 009
//23.11.2022, 22:21
using System;

public class FruitOrVegetable
{
    static void Main()
    {
        string product = Console.ReadLine();

        switch(product)
        {
            case "banana":
            case "apple":
            case "kiwi":
            case "cherry":
            case "lemon":
            case "grapes":
                Console.WriteLine("fruit");
                break;
            case "tomato":
            case "cucumber":
            case "pepper":
            case "carrot":
                Console.WriteLine("vegetable");
                break;
            default:
                Console.WriteLine("unknown");
                break;

        }
    }
}