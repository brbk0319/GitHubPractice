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
namespace Program
{
    public class Program
    {


        public static void Main()
        {
            Console.WriteLine("Welcome to the Hero's Menu!");
            string menuQuery = "Where would you like to go?\n     1. Create a Hero \n     2. View your Hero \n     3. Edit your Hero \n     4. Settings \n     5. Exit";
            while (true)
            {

                getAnswer.GetEnum(menuQuery, out MainMenu menuChoice);

                switch (menuChoice)
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
                        string exitConfirmation = "Are you CERTAIN you wish to leave?\n     Yes\n     No";

                        getAnswer.GetYesNo(exitConfirmation, out bool choice);
                        if (choice == true)
                        {
                            Console.WriteLine("Farewell Adventurer!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Right on, let's go back.");
                        }
                        break;

                    case MainMenu.developer:
                        Console.WriteLine(":89\nWelcome to the developer's side.\nOkay bye\n");
                        break;
                    default:
                        Console.WriteLine("You think you're clever, huh? Try again Hero.'");
                        break;


                }
            }
        }
        public class getAnswer
        {
            public static void GetEnum(string question, out MainMenu menuChoice)
            {
                menuChoice = MainMenu.viewMenu;
                while (true)
                {
                    Console.WriteLine(question);
                    string input = Console.ReadLine() ?? "";

                    if (Enum.TryParse(input, true, out menuChoice))
                    { return; }
                    else { Console.WriteLine("Haha hero, try again."); }
                }
            }
            public static void GetYesNo(string question, out bool choice)
            {
                choice = false;
                while (true)
                {
                    Console.WriteLine(question);
                    string input = Console.ReadLine() ?? "";
                    if (input == "yes" || input == "YES" || input == "Yes" || input == "Yeah" || input == "yeah")
                    { choice = true; return; }
                    else if (input == "no" || input == "NO" || input == "No" || input == "nah")
                    { choice = false; return; }
                    else
                    { Console.WriteLine("Haha hero, try again."); }
                }
            }
        }
    }
}


