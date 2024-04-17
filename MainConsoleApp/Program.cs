using System;

namespace ShortAdventureGame
{
    class Program
    {
        static void Main (string[] args)        //Main method. Entry point. Starts off a program. Commit this to memory for as long as you code.
    {
        StartAdventure();                   
    }

        static void StartAdventure()                //Added this method in as a "checkpoint" for the game, place to return to when choosing "retry"

        {
            Console.WriteLine("Greetings, adventurer! On the road between quests, you arrive at a choice-");
            Console.WriteLine("You have hit a fork in the road! Before you are two choices...");
            Console.WriteLine("To the east road, a swampy lowland of murky and fog devours the horizon.");
            Console.WriteLine("To the west road, your path stretches high into the hills, slinking into misty mountain peaks.");
            Console.WriteLine("How shall you proceed?:");
            Console.WriteLine("1. Through the swamp? [Swamp path] or 2. Through the Mountains? [Mountain path]");

            string? routeChoice = Console.ReadLine();

            switch (routeChoice)
            {
                case "1":
                    GoSwamp();
                    break;
                case "2":
                    GoMountains();
                    break;
                default:
                    Console.WriteLine ("What say ye? That's not an option, adventurer. Try again...");
                    StartAdventure();
                    break;
            }
    }

static void GoSwamp()                 //This Pattern of 'declare method, switch-case of choice, link to new method* is the basis of the entire game-- it's just a series of encounters and choices.
{
    Console.WriteLine("As you trudge through the inky muck, you happen upon a canoe with no owner to be seen...");
    Console.WriteLine("With this, you could take the shortest route through the swampland directly across the water.");
    Console.WriteLine("However, there is still the strip of dry toe-path you've taken so far,\n zig-zagging into the murk. This route would be longer, but will spare you");
    Console.WriteLine("from any risks that may lurk beneath the water...");
    Console.WriteLine("How shall you proceed?");
    Console.WriteLine("1. \"I shall commandeer this vessel!\" [Boat]");
    Console.WriteLine("2. \"Mine feet are fine enough; I will walk.\" [Walk]");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":                                           //Cases can have a little flavor text when selected, or all that can just be included in the "preamble" of each method.
            BearigatorEncounter();
            break;
        case "2":
            CreepyHutEncounter();
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            GoSwamp();
            break;
    }
}

static void BearigatorEncounter()
{
    Console.WriteLine("As you paddle along, you find yourself covering distance quite quickly.");
    Console.WriteLine("But all at once, the air has gone still... The chatter of bugs and bird replaced with nothingness.");
    Console.WriteLine("Suddenly, a massive form bursts forth from the water!");
    Console.WriteLine("It's a Bearigator: the foulest of swamp-beasts!");
    Console.WriteLine("Time is short-- do you risk an attack, striking with your oar? Or attempt a desperate escape?");
    Console.WriteLine("1. Strike it with the oar! [Combat]");
    Console.WriteLine("2. Try to escape! [Flee]");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You try in vain to beat back the Bearigator with the oar, but...");
            Console.WriteLine("It was all for not. You lack the strength to deal meaningful damage.");
            Console.WriteLine("The monstrosity lunges...");
            YouAreDead();
            // Outcome of losing the game
            break;
        case "2":
            Console.WriteLine("In a flurry of movement, you paddle as fast as you can, trying to escape the Bearigator!");
            Console.WriteLine("Against all odds, you manage to get away! Ahead you see faint veins of sunlight- the swamp's edge is near.");
            EdgeOfArea();
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            BearigatorEncounter();
            break;
    }
}

static void CreepyHutEncounter()              
{
    Console.WriteLine("As you journey, you wonder if the security of dry land was truly so.");
    Console.WriteLine("In the distance, you spot a dilapidated structure- a huge, crude thatch hut.");
    Console.WriteLine("For all its sorriness, the abode actually has a front door...");
    Console.WriteLine("...However, you cannot discern the nature of its inhabitants from the outside.");
    Console.WriteLine("Do you risk knocking on the door, or sneak away past it?");
    Console.WriteLine("1. Knock on the door");
    Console.WriteLine("2. Sneak past");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You steel yourself and go to knock on the door of the creepy hut...");
            KnockOnHut();
            break;
        case "2":
            Console.WriteLine("You decide to slink past the creepy hut.");
            Console.WriteLine("As you run, you reach the edge of the swamp.");
            EdgeOfArea();
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            CreepyHutEncounter();
            break;
    }
}

static void EdgeOfArea()          //Some methods are easier to just share between switch-case options. Things like win/loss cons that would stay the same anyway can just be recycled.
{
    Console.WriteLine("You can see it... you've finally reached the path onwards!");
    Console.WriteLine("Freedom lies straight ahead... Do you venture on, or linger in this place?");
    Console.WriteLine("1. Leave");
    Console.WriteLine("2. Stay");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You leave the swamp behind and see a village ahead; you live to adventure another day!");
            // Outcome of winning the game
            break;
        case "2":
            Console.WriteLine("You decide to stay a little longer...");
            Console.WriteLine("A poor choice-- you get Shreked by an ogre AND mauled by a Bearigator!");
            Console.WriteLine("A terrible end, to be sure...");
            YouAreDead();
            // Outcome of losing the game
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            EdgeOfArea();
            break;
    }
}

static void KnockOnHut()
{
        Console.WriteLine("You gently tap the shambling door, quickly drawing the attention of whatever lurks inside");
        Console.WriteLine("A hulking ogre responds in not-so-kind, yanking his own door off its hinges!");
        Console.WriteLine("The behemoth roars, moving forward to grapple you with malevolent intent...");
        Console.WriteLine("1. \"Have at thee, monster!\" [Combat]");
        Console.WriteLine("2. Make a run for it! [Flee]");
        string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You foolishly attempt to swing on the 9ft, 600lb creature.");
            System.Console.WriteLine("To the surprise of nobody, not even yourself, it is pointless");
            System.Console.WriteLine("He catches your entire upper arm between two colossal fingers");
            System.Console.WriteLine(" \"Heheh... Not in *my* swamp, laddie...\" ");
            System.Console.WriteLine("He envelopes your head in a gritty, foul fist-- and squeezes.");
            YouAreDead();
            break;
        case "2":
            Console.WriteLine("You make a run for it, before the monster can emerge fully from his hideaway");
            System.Console.WriteLine("Your lungs burn as you sprint through the brush and much...");
            System.Console.WriteLine("...but your struggle yields promise!");
            System.Console.WriteLine("Just ahead, you can see the sunlight breaching the edge of the marshland treeline!");
            EdgeOfArea();
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            KnockOnHut();
            break;
    }
}

static void YouAreDead()                    //USE THIS FOR BOTH ROUTES!
{
    Console.WriteLine("Your journey has met a terrible end. Retry?");
    Console.WriteLine("Type 'yes' to continue, or 'no' to surrender to fate");

    string? retry = Console.ReadLine()?.ToLower();

    if (retry == "yes" || retry == "Yes" || retry == "YES")
    {
        StartAdventure();
    }
    else if (retry == "no" ||retry == "No" || retry == "NO" )
    {
        Console.WriteLine("Farewell, adventurer!");
        Environment.Exit(0); // Exit the program with exit code 0
    }
    else
    {
        Console.WriteLine("Invalid input. Please type 'yes' to continue, or 'no' to exit.");
        YouAreDead(); // Restarts the method until valid input is typed
    }
}

// ---------------------------------------------------------------------Begin alt MOUNTAIN Route from here down-----------------------------------------------------------------//

    static void GoMountains()
    {
        Console.WriteLine("You opt for the high road, and make your way up the misty mountain trail.");
        Console.WriteLine("The air turns thin, and the cold wind stabs through your garb");
        Console.WriteLine("Muscles aching, head light, ");
        Console.WriteLine("You...");
        Console.WriteLine("You...");
        string? choice = Console.ReadLine();

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
    
};

//Laundry List

// Finish all the switch/cases choices for the Mountain and Swamp routes (Not done)
// Insert AT LEAST TWO instances of Classes and Methods (Not done)
// Design and implement a functional UI (Not done)