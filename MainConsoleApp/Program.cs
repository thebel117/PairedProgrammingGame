using System;

namespace ShortAdventureGame
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Greetings, adventurer! On the road between quests, you arrive at a sudden choice-");
            Console.WriteLine("You have hit a fork in the road! Before you have two choices...");
            Console.WriteLine("To the east road, a swampy lowland of murky and fog devours the horizon.");
            Console.WriteLine("To the west road, it stretches high into the hills, slinking into the misty mountain peaks.");
            Console.WriteLine("Which route do you take; swamp or mountains?");

            string routeChoice = Console.ReadLine();

            switch (routeChoice)
            {
                case "swamp":
                    GoSwamp();
                    break;
                case "mountains":
                    GoMountains();
                    break;
                default:
                    Console.WriteLine ("What say ye? That's not an option, adventurer. Try again...");
                    break;
            }
    }
        static void GoSwamp()
    {
        Console.WriteLine("As you trudge amidst the inky muck of the swamp you happen upon a boat, with no captain to be seen...");
        Console.WriteLine("However, there is also a strip of dry land ahead. You could use either to make your way quicker...");
        Console.WriteLine(" How do you proceed?");
        Console.WriteLine("1. I shall commandeer this vessel!");
        Console.WriteLine("2. Mine feet are fine enough; I'll walk.");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "boat":
                Console.WriteLine("You...");
                break;
            case "walk":
                Console.WriteLine("You...");
                break;
            default:
                Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
                break;
        }
    }

    static void GoMountains()
    {
        Console.WriteLine("You...");
        Console.WriteLine("You...");
        Console.WriteLine("You...");
        Console.WriteLine("You...");
        Console.WriteLine("You...");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("You...");
                break;
            case "2":
                Console.WriteLine("You...");
                break;
            default:
                Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
                break;
        }
    }
    }
}

