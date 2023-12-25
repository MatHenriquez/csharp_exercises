string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

int maxPets = 8;
string? readResult;
string menuSelection = "";

string[,] ourAnimals = new string[maxPets, 6];

for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();

    if (readResult == null)
        continue;

    menuSelection = readResult.ToLower();

    void displayFeatureInProgressMessage(int option)
    {
        switch (option)
        {
            case 1:
                showAllPets();
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
                break;
            case 2:
                addNewPet();
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
                break;

            case 3:
            case 4:
                Console.WriteLine("Challenge Project - please check back soon to see progress.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
                break;

            default:
                Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
                break;
        }

    }

    Console.WriteLine($"You selected menu option {menuSelection}.");
    switch (menuSelection)
    {
        case "1":
            displayFeatureInProgressMessage(1);
            break;

        case "2":
            displayFeatureInProgressMessage(2);
            break;

        case "3":
            displayFeatureInProgressMessage(3);
            break;

        case "4":
            displayFeatureInProgressMessage(4);
            break;

        case "5":
            displayFeatureInProgressMessage(5);
            break;

        case "6":
            displayFeatureInProgressMessage(6);
            break;

        case "7":
            displayFeatureInProgressMessage(7);
            break;

        case "8":
            displayFeatureInProgressMessage(8);
            break;

        default:
            break;
    }
} while (menuSelection != "exit");

Console.WriteLine($"You selected menu option {menuSelection}.");
Console.WriteLine("Press the Enter key to continue");

void showAllPets()
{
    for (int i = 0; i < maxPets; i++)
    {
        if (ourAnimals[i, 0] != "ID #: ")
        {
            Console.WriteLine();
            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine(ourAnimals[i, j]);
            }
        }
    }
}

void addNewPet()
{
    string anotherPet = "y";
    int petCount = 0;

    for (int i = 0; i < maxPets; i++)
    {
        if (ourAnimals[i, 0] != "ID #: ")
        {
            petCount++;
        }

    }

    while (petCount < maxPets && anotherPet == "y")
    {
        Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
        Console.WriteLine("Do you want to enter info for another pet (y/n)");

        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                anotherPet = readResult.ToLower();
            }

        } while (anotherPet != "y" && anotherPet != "n");

        petCount++;
    }

    Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
}

void isNewPetValid(int petCount)
{
    bool validEntry = false;

    do
    {
        int petAge;
        Console.WriteLine("Enter the pet's age or enter ? if unknown");
        readResult = Console.ReadLine();

        if (readResult != null)
            animalAge = readResult;

        if(animalAge != "?")
            validEntry = int.TryParse(animalAge, out petAge);
        else
            validEntry = true;

        Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
        readResult = Console.ReadLine();

        if (readResult != null)
            animalSpecies = readResult.ToLower();

        validEntry = animalSpecies == "dog" && animalSpecies == "cat";
    } while (validEntry == false);

    animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
}

