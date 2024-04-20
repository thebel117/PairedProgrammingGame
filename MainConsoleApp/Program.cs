using System;

namespace ShortAdventureGame
{
class Program
{
static void Main (string[] args)        //Main method. Entry point. Starts off a program. Commit this to memory for as long as you code.
    {
        StartAdventure();                   
    }

static bool isArcherSelected = false;
static bool isBarbarianSelected = false;
static bool isMageSelected = false;

static void StartAdventure()
{
    Console.WriteLine("Greetings, hero! Choose your adventurer class:");
    Console.WriteLine("1. Archer");
    Console.WriteLine("2. Barbarian");
    Console.WriteLine("3. Mage");

    string? classChoice = Console.ReadLine();

    switch (classChoice)
    {
        case "1":
            Console.WriteLine("You have chosen the path of the Archer.");
            isArcherSelected = true;
            ArcherPath();
            break;
        case "2":
            Console.WriteLine("You have chosen the path of the Barbarian.");
            isBarbarianSelected = true;
            BarbarianPath();
            break;
        case "3":
            Console.WriteLine("You have chosen the path of the Mage.");
            isMageSelected = true;
            MagePath();
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a valid option.");
            StartAdventure();
            break;
    }
}

static void ArcherPath()
{
    Console.Clear();
    Console.WriteLine("As an Archer, you specialize in ranged combat with your bow. Flying beasts are no match for your aim!");
    ChooseRoute();
}

static void MagePath()
{
    Console.Clear();
    Console.WriteLine("As a Mage, you wield powerful magic. Dark monsters fear your radiant spells!");
    ChooseRoute();
}

static void BarbarianPath()
{
    Console.Clear();
    Console.WriteLine("As a Barbarian, you are a fierce warrior of brute strength. There's nothing you can't beat in a fist-fight!");
    ChooseRoute();
}

static void ChooseRoute()
        {
            Console.WriteLine("Greetings, adventurer! On the road between quests, you arrive at a choice-");
            Console.WriteLine("You have hit a fork in the road! Before you are two choices...");
            Console.WriteLine("To the east road, a swampy lowland of murky and fog devours the horizon.");
            Console.WriteLine("To the west road, your path stretches high into the hills, slinking into misty mountain peaks.");
            Console.WriteLine("How shall you proceed?:");
            Console.WriteLine("1. Through the swamp? [SWAMP ROUTE] or 2. Through the Mountains? [MOUNTAIN ROUTE]");

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
    System.Console.Clear();
    Console.WriteLine("As you trudge through the inky muck, you happen upon a canoe with no owner to be seen...");
    Console.WriteLine("With this, you could take the shortest route through the swampland directly across the water.");
    Console.WriteLine("However, there is still the strip of dry toe-path you've taken so far,\n zig-zagging into the murk. This route would be longer, but will spare you");
    Console.WriteLine("from any risks that may lurk beneath the water...");
    Console.WriteLine("How shall you proceed?");
    Console.WriteLine("1. \"I shall commandeer this vessel!\" [BOAT]");
    Console.WriteLine("2. \"Mine feet are fine enough; I will walk.\" [WALK]");
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
            System.Console.Clear();
            GoSwamp();
            break;
    }
}

static void BearigatorEncounter()
{
    System.Console.Clear();
    Console.WriteLine("As you paddle along, you find yourself covering distance quite quickly.");
    Console.WriteLine("But all at once, the air has gone still... The chatter of bugs and bird replaced with nothingness.");
    Console.WriteLine("Suddenly, a massive form bursts forth from the water!");
    Console.WriteLine("It's a Bearigator: the foulest of swamp-beasts!");
    Console.WriteLine("Time is short-- do you risk an attack, striking with your oar? Or attempt a desperate escape?");
    Console.WriteLine("1. Strike it with the oar! [COMBAT]");
    Console.WriteLine("2. Try to escape! [FLEE]");

    if (isMageSelected)
    {
        Console.WriteLine("3. Shoot lightning at the Bearigator! [LIGHTNING]");
    }

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
        case "3":
            if (isMageSelected)
            {
                Console.WriteLine("With a flick of your wrist, you conjure a bolt of lightning and unleash it upon the Bearigator!");
                Console.WriteLine("The creature convulses in agony before succumbing to the powerful magic.");
                System.Console.WriteLine("You take some time to harvest pieces of the monster's remains- these will fetch a high price at a potion-maker's shop!");
                System.Console.WriteLine("You paddle across the remainder of the swamp without issue, eventually mooring on the opposite side");
                System.Console.WriteLine("From what you can tell, it is only a short jaunt on foot left.");
                EdgeOfArea();
            }
            else
            {
                Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
                Console.Clear();
                BearigatorEncounter();
            }
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            System.Console.Clear();
            BearigatorEncounter();
            break;
    }
}

static void CreepyHutEncounter()              
{
    System.Console.Clear();
    Console.WriteLine("As you journey, you wonder if the security of dry land was truly so.");
    Console.WriteLine("In the distance, you spot a dilapidated structure- a huge, crude thatch hut.");
    Console.WriteLine("For all its sorriness, the abode actually has a front door...");
    Console.WriteLine("...However, you cannot discern the nature of its inhabitants from the outside.");
    Console.WriteLine("Do you risk knocking on the door, or sneak away past it?");
    Console.WriteLine("1. Knock on the door [KNOCK]");
    Console.WriteLine("2. Sneak past [SNEAK]");
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
            System.Console.Clear();
            CreepyHutEncounter();
            break;
    }
}

static void EdgeOfArea()          //Some methods are easier to just share between switch-case options. Things like win/loss cons that would stay the same anyway can just be recycled.
{
    Console.WriteLine("You can see it... you've finally reached the path onwards!");
    Console.WriteLine("Freedom lies straight ahead... Do you venture on, or linger in this place?");
    Console.WriteLine("1. [LEAVE]");
    Console.WriteLine("2. [STAY]");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You leave the dangers behind and see a village on the horizon ahead; you live to adventure another day!");
            // Outcome of winning the game
            break;
        case "2":
            Console.WriteLine("You decide to stay a little longer...");
            Console.WriteLine("A poor choice-- the dangers behind you catch up..!");
            Console.WriteLine("A terrible end, to be sure...");
            YouAreDead();
            // Outcome of losing the game
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            System.Console.Clear();
            EdgeOfArea();
            break;
    }
}

static void KnockOnHut()
{
    System.Console.Clear();
    Console.WriteLine("You gently tap the shambling door, quickly drawing the attention of whatever lurks inside");
    Console.WriteLine("A hulking ogre responds in not-so-kind, yanking his own door off its hinges!");
    Console.WriteLine("The behemoth roars, moving forward to grapple you with malevolent intent...");
    Console.WriteLine("1. \"Have at thee, monster!\" [COMBAT]");
    Console.WriteLine("2. Make a run for it! [FLEE]");

    if (isBarbarianSelected)
    {
        Console.WriteLine("3. Beat the ogre into submission! [BEAT]");
    }

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You foolishly attempt to swing on the 9ft, 600lb creature.");
            Console.WriteLine("To the surprise of nobody, not even yourself, it is pointless");
            Console.WriteLine("He catches your entire upper arm between two colossal fingers");
            Console.WriteLine(" \"Hehehee... Not in *my* swamp, laddie...\" ");
            Console.WriteLine("He envelopes your head in a gritty, foul fist-- and squeezes.");
            YouAreDead();
            break;
        case "2":
            Console.WriteLine("You make a run for it, before the monster can emerge fully from his hideaway");
            Console.WriteLine("Your lungs burn as you sprint through the brush and muck...");
            Console.WriteLine("...but your struggle yields promise!");
            Console.WriteLine("Just ahead, you can see the sunlight breaching the edge of the marshland treeline!");
            EdgeOfArea();
            break;
        case "3":
            if (isBarbarianSelected)
            {
                Console.WriteLine("With a mightier roar than his, you charge headlong into the ogre's hut, unleashing a barrage of blows!");
                Console.WriteLine("The ogre staggers under your brutal assault, eventually collapsing under your might.");
                System.Console.WriteLine("The beast heaves blood, and with his dying breath exclaims:");
                System.Console.WriteLine(" \"G-get..out...of...my...swaaaaamp...\" ");
                System.Console.WriteLine("The beast slain, you help yourself to his meager belongings. No sense leaving this swamp with no treasure!");
                System.Console.WriteLine("You leave and continue down the path past the hut.");
                EdgeOfArea();
            }
            else
            {
                Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
                Console.Clear();
                KnockOnHut();
            }
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            System.Console.Clear();
            KnockOnHut();
            break;
    }
}


static void YouAreDead()                    //USE THIS FOR BOTH ROUTES!
{
    Console.WriteLine("Your journey has met a pitiful end. Retry?");
    Console.WriteLine("Type 'yes' to continue, or 'no' to surrender to fate");

    string? retry = Console.ReadLine();

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
        System.Console.Clear();
        Console.WriteLine("You opt for the high road, and make your way up the misty mountain trail.");
        Console.WriteLine("The air turns thin, and the cold wind stabs through your garb.");
        Console.WriteLine("Muscles aching, head light, you realize you must expedite your journey through the mountains or perish in them. ");
        System.Console.WriteLine("But what luck..! Ahead you see...");
        Console.WriteLine("1. The entrance to a cave, leading down into the belly of the mountains. [ENTER CAVE]");
        Console.WriteLine("2. An old rappel, anchored into the cliff face. [CLIMB RAPPEL]");

        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("You cannot stand the biting wind and cold any longer; you decide to enter the cave.");
                GoCavern();
                break;
            case "2":
                Console.WriteLine("The longer you spend on this mountain, the more likely you will die. You choose to use the rappel to descend quickly.");
                GoRappel();
                break;
            default:
                Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
                System.Console.Clear();
                GoMountains();
                break;
        }
    }

static void GoCavern()
{
    System.Console.Clear();
    Console.WriteLine("You enter the dark cavern entrance hidden into the mountainside.");
    Console.WriteLine("The air grows warm as you venture inside, the darkness enveloping you.");
    Console.WriteLine("Echoes of dripping water and distant rumblings fill the cavern.");
    Console.WriteLine("Will you proceed deeper into the darkness..?");
    Console.WriteLine("1. Continue cautiously. [CONTINUE]");
    Console.WriteLine("2. Retreat back outside. [GO BACK]");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You press on, determined to uncover the secrets of the cavern.");
            DragonsDen();
            break;
        case "2":
            Console.WriteLine("You decide to retreat, wary of the unknown dangers lurking within.");
            System.Console.WriteLine("You exit the mouth of the cave, and head to the rappel instead");
            GoRappel();
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            System.Console.Clear();
            GoCavern(); // Rerun the method
            break;
    }
}
static void DragonsDen()
{
    System.Console.Clear();
    Console.WriteLine("As you press onward, you find yourself in a vast chamber deep within the cavern.");
    Console.WriteLine("The chamber is dimly lit with the glow of molten lava pools, reflecting off something in the center of the space...");
    Console.WriteLine("The reflective mount at the center of the chamber is gold..! Coins, bars, and armor. However, sleeping atop it...");
    Console.WriteLine("You see a red dragon wyrmling, soundly at rest and unaware of your presence.");
    System.Console.WriteLine("You could easily slip past the dragon and exit the other side of the chamber.");
    System.Console.WriteLine("Of course... if you risked an approach, you could pilfer enough gold to last you a lifetime!");
    Console.WriteLine("1. Give me that gold! [APPROACH DRAGON]");
    Console.WriteLine("2. Move past silently. [AVOID DRAGON]");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You cautiously approach the dragon, steadying your breath. Wealth without measure, right ahead of you!");
            System.Console.WriteLine("But the beating of your heart is loud... and getting louder..?");
            System.Console.WriteLine("You realize the beating sound filling the cave isn't your heart, but a set of massive wings.");
            System.Console.WriteLine("You slowly turn to see it: an adult red dragon-- watching YOU approach her youngling!");
            DragonEncounter(isArcherSelected);
            break;
        case "2":
            Console.WriteLine("You quietly lurk past, not daring to provoke the dragon for mere coin.");
            System.Console.WriteLine("You stealth your way around the chamber and come upon a long and narrow passage...");
            SecretTunnel();
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            System.Console.Clear();
            DragonsDen();
            break;
    }
}

static void AvoidDragon()
{
    System.Console.Clear();
    Console.WriteLine("You skulk past the slumbering destroyer, carefully keeping quiet as one could.");
    Console.WriteLine("You successfully slip past, and reach the exit to the chamber on the other side");
    System.Console.WriteLine("Still... The allure of gold is rather tempting... Do you turn back, or press on?");
    System.Console.WriteLine("1. Go back for the gold [TURN BACK]");
    System.Console.WriteLine("2. No extra risks, push on! [CONTINUE]");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You are an adventurer through and through...");
            System.Console.WriteLine("Danger, treasure, and glory define you, after all.");
            System.Console.WriteLine("You turn heel, and make way for the sleeping dragon's horde, heart pounding with anticipation.");
            System.Console.WriteLine("But the beating of your heart is loud... and getting louder..?");
            System.Console.WriteLine("You realize the beating sound filling the cave isn't your heart, but a set of massive wings.");
            System.Console.WriteLine("You slowly turn to see it: an adult red dragon-- watching YOU approach her youngling!");
            DragonEncounter(isArcherSelected);
            break;
        case "2":
            Console.WriteLine("You are too seasoned of an adventurer to take an unnecessary risk like poking a sleeping dragon.");
            System.Console.WriteLine("You continue onward to the narrow exit of the chamber");
            SecretTunnel();
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            System.Console.Clear();
            AvoidDragon(); // Rerun the method
            break;
    }
}
static void DragonEncounter(bool isArcherSelected)
{
    Console.WriteLine("Your situation has turned grim, to say the least");
    Console.WriteLine("The she-dragon's belly begins to glow as she readies to blow a burst of flames!");
    Console.WriteLine("You must act quickly if you intend to survive!");
    Console.WriteLine("1. Beg the dragon for mercy [BEG]");
    Console.WriteLine("2. Run from the chamber [FLEE]");

    if (isArcherSelected)
    {
        Console.WriteLine("3. Shoot the dragon down! [SHOOT]");
    }

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("You make an attempt to seek mercy from the beast, hoping your pleas can translate somehow--");
            Console.WriteLine("This comes to no avail. She cranes her neck before engulfing you in flames...");
            YouAreDead();
            break;
        case "2":
            Console.WriteLine("You make a mad dash from the chamber, clamoring your way over mounds of gold and into the long, narrow hall on the opposite side.");
            Console.WriteLine("By the skin of your teeth, and with singed eyebrows, you have managed to escape!");
            SecretTunnel();
            break;
        case "3":
            if (isArcherSelected)
            {
                Console.WriteLine("With a steady hand and a sharp eye, you draw your bow and take aim at the dragon's belly!");
                Console.WriteLine("Your arrow flies true, piercing the dragon's scales and bringing her crashing down!");
                System.Console.WriteLine("The panicked infant dragon flutters off in fear to his injured mother.");
                System.Console.WriteLine("With this new opportunity, you fill your satchel with gold before dashing out the exit!");
                SecretTunnel();
                // Add victory scenario here
            }
            else
            {
                Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
                Console.Clear();
                DragonEncounter(isArcherSelected);
            }
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            Console.Clear();
            DragonEncounter(isArcherSelected); // Rerun the method
            break;
    }
} 

static void SecretTunnel()
{
    Console.WriteLine("You find yourself exiting into an ancient subterranean railway, an old Dwarven mineshaft.");
    Console.WriteLine("If you follow the mine cart tracks you are certain to emerge at the foot of the mountain eventually.");
    Console.WriteLine("Of course, there are plenty of side-caverns to explore too. Perhaps one contains some treasure to loot?");
    Console.WriteLine("1. Stay the course, and leave this place. [LEAVE]");
    Console.WriteLine("2. Take a look around for loot! [STAY]");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("After hours of underground hiking, you see the light of day ahead--");
            Console.WriteLine("There, just ahead, you see it! The exit from the mountains!");
            System.Console.WriteLine("You bask in the light of day as you exit into the valleys on the opposite side of the mountains.");
            EdgeOfArea();
            break;
        case "2":
            Console.WriteLine("You slink about mines, but quickly lose your way.");
            Console.WriteLine("Hours turn to days, then weeks, until your body is too weak to move.");
            Console.WriteLine("You collapse in the caves, life slipping away...");
            YouAreDead();
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            System.Console.Clear();
            SecretTunnel(); // Rerun the method
            break;
    }
}
static void GoRappel()
{
    System.Console.Clear();
    Console.WriteLine("The rope looks ancient and the iron fasteners anchored into the rock look no younger.");
    Console.WriteLine("However, the way down is a straight shot. Should the components hold out, you could descend the mountain's other side in minutes.");
    Console.WriteLine("You belay yourself and prepare to descend, but give this one more thought...");
    Console.WriteLine("Will you certainly take this risk?");
    System.Console.WriteLine("1. All or nothing! [DESCEND]");
    System.Console.WriteLine("2. On second thought, I'll try the cave [GO BACK]");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("The first 20 feet go smoothly... then 50 feet, then 100 feet.");
            System.Console.WriteLine("You get nearly halfway down when your luck runs out- the rope begins to fray!");
            System.Console.WriteLine("You have seconds before it snaps and you are in free-fall..!");
            RopeBreaks();
            break;
        case "2":
            Console.WriteLine("Having weighed out the risks, you figure that the caves are the better bet.");
            GoCavern();
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            System.Console.Clear();
            GoRappel(); // Rerun the method
            break;
    }
}
static void RopeBreaks()
{
    System.Console.Clear();
    Console.WriteLine("The rope gives, and all at once you are plummeting to the ground-- NOT exactly the speedy exit you'd hoped for.");
    System.Console.WriteLine("With your honed instincts, you see two options to save yourself below: a large jutting rock you could grab, or a narrow protruding branch.");
    System.Console.WriteLine("Time is of the essence, every millisecond counts-- what will you grab, adventurer?");
    System.Console.WriteLine("1. Grab for the rock! [ROCK]");
    System.Console.WriteLine("2. Grab for the branch! [BRANCH]");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Your instincts tell you that the rock is the safer option.");
            System.Console.WriteLine("However, your instincts also told you to descend a cliff with an old, decaying rappel.");
            System.Console.WriteLine("The rock crumbles under your sheer weight, and you continue to plummet to your grave.");
            YouAreDead();
            break;
        case "2":
            Console.WriteLine("While the rock may seem sturdier, you know that whatever roots are anchoring the branch into the cliff make it more secure.");
            System.Console.WriteLine("You snatch it into your grip and cling for dear life. The branch bounces a bit, but does not give way.");
            System.Console.WriteLine("As you assess your situation, you see that there is actually a small tunnel just to the side of where the branch grows.");
            System.Console.WriteLine("With no other options, you pull yourself in and begin an army crawl through the hole.");
            System.Console.WriteLine("After 100 feet of crawling in total darkness, you see dim light ahead!");
            System.Console.WriteLine("The passage spits you out into a larger subterranean complex within the mountain.");
            SecretTunnel();
            break;
        default:
            Console.WriteLine("What say ye? That's not an option, adventurer. Try again...");
            System.Console.Clear();
            RopeBreaks(); // Rerun the method
            break;
    }
}
}
};