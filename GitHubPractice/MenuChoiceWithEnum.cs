/* 
The program should:
    Display a numbered menu
    Ask the user to make a selection
    Convert the input into an enum value
    Use a switch statement to respond appropriately
    End cleanly when the user chooses to exit

Create an enum named MainMenu with at least the following values:
    ViewProfile
    EditProfile
    Settings
    Exit
    (You may add more if you want.)

Program Behavior
    The menu repeats until the user selects Exit
    Each menu option should print a short message describing what would happen
    Invalid input should not crash the program

Functional Requirements
    Must use an enum
    Must use a switch statement
    Must use at least one method besides Main
    Must use a loop
    No magic numbers scattered throughout the code
    Clear variable and method names (no comments required)
 */


using MainMenuEnums;

static void Main()
{
    Console.WriteLine("Welcome to the Hero's Menu! \nWhere would you like to go?'");
    //recieve input loop/switch thing
    //show menu
    Console.WriteLine("1. Create a Hero \n2. View your Hero \n3. Edit your Hero \n4. Settings \n5. Exit");
    int responseNum = 0;
    string response = Console.ReadLine();

    switch (response)
    {
        case MainMenu.createHero:
            Console.WriteLine("Wonderful, let's begin! With this option, you would name your Hero and start your adventure.'");
            break;
        case MainMenu.viewHero:
            Console.WriteLine("Here is your current Hero! This option would show your current character stats and any possessions");
            break;
        case MainMenu.editHero:
            Console.WriteLine("You want to change something? Choosing this lets you change some things about your Hero, like the name.");
            break;
        case MainMenu.settings:
            Console.WriteLine("Let's go to Settings! This option might let you change the text color, or delete your current hero and create a new one.'");
            break;
        case MainMenu.exit:
            Console.WriteLine("Are you CERTAIN you wish to leave? This option exits the Main Menu, and closes the program.");
            break;
        case MainMenu.developer:
            Console.WriteLine(":89. Welcome to the developer's side.");
            break;
        default:
            Console.WriteLine("You think you're clever, huh? Try again Hero.'");
            break;

    }
}