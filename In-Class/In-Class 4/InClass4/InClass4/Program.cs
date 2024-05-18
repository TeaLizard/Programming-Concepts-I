// Owen Williams || In class assignment 4


// Welcome
// How many mother puppies?
// Create [x, 2] array with names and two litters per mother
// Display info about dogs when name entered
// Loop display stuff until prompted to stop

int numberOfDogs;
int placeholder;


while (true) // Numbers only
{
    Console.WriteLine("How many mother dogs do you have?");
    string numberOfDogsString = Console.ReadLine();
    if (int.TryParse(numberOfDogsString, out numberOfDogs))
    {
        break;
    }
    else
    {
        Console.WriteLine("Enter only an integer.");
    }
}

string[,] dogsArray = new string[numberOfDogs + 1, 3];

for (int i = 0; i <  numberOfDogs; i++)
{
    Console.WriteLine($"Enter the mother dog {i + 1}'s name.");
    dogsArray[i, 0] = Console.ReadLine();

    while (true) // Numbers only
    {
        Console.WriteLine($"How many children does {dogsArray[i, 0]} have in their first litter?");
        dogsArray[i, 1] = Console.ReadLine();
        if (int.TryParse(dogsArray[i, 1], out placeholder))
        {
            break;
        }
        else
        {
            Console.WriteLine("Enter only an integer.");
        }
    }

    while (true) // Numbers only
    {
        Console.WriteLine($"How many children does {dogsArray[i, 0]} have in their second litter?");
        dogsArray[i, 2] = Console.ReadLine();
        if (int.TryParse(dogsArray[i, 2], out placeholder))
        {
            break;
        }
        else
        {
            Console.WriteLine("Enter only an integer.");
        }
    }
}



int checker = 0;
string whichDog = "";
bool displayAgainBool = true;
while (displayAgainBool)
{
    if(checker == 0)
    {
        Console.WriteLine("Which mother dog would you like information about?");
        whichDog = Console.ReadLine();
    }

    if (checker == numberOfDogs + 1)
    {
        Console.WriteLine("Dog not found.");
        checker = 0;
        DisplayAgain();
    }
    else if (whichDog == dogsArray[checker, 0])
    {
        DisplayInfo(checker);
        if (DisplayAgain() == true)
        {
            continue;
        }
        else
        {
            break;
        }
    }
    else
    {
        checker++;
    }
}

Console.WriteLine("Have a good day!");

void DisplayInfo(int a)
{
    int totalPuppies;
    double averagePuppies;

    Console.WriteLine($"The first litter has {dogsArray[a ,1]} puppies.");
    Console.WriteLine($"The second litter has {dogsArray[a, 2]} puppies.");
    totalPuppies = int.Parse(dogsArray[a, 1]) + int.Parse(dogsArray[a, 2]);
    Console.WriteLine($"The total amount of puppies is {totalPuppies}.");
    averagePuppies = (double.Parse(dogsArray[a, 1]) + double.Parse(dogsArray[a, 2])) / 2;
    Console.WriteLine($"The average amount of puppies per litter is {averagePuppies}.");
}

bool DisplayAgain()
{
    

    while (true)
    {
        Console.WriteLine("Would you like to display info of another mother dog?");
        string displayAgainStringOriginal = Console.ReadLine();
        string displayAgainString = displayAgainStringOriginal.ToLower();

        if (displayAgainString == "yes" || displayAgainString == "y")
        {
            displayAgainBool = true;
            checker = 0;
            return true;
        }
        else if (displayAgainString == "no" || displayAgainString == "n")
        {
            displayAgainBool = false;
            return false;
        }
        else
        {
            Console.WriteLine("Enter yes or no");
        }
    }
    return false;
}

Console.ReadLine();