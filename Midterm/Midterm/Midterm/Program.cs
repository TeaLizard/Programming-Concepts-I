// Owen Williams || Programming Concepts 1


//Display instructions
//Enter a contenent
//Display info or error message
//Ask if they want another continent


Console.WriteLine("Hello, this application tells you how many countries are in each respective country.");
Console.WriteLine("");

bool keepConvo = false;
while (keepConvo == false)
{
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("Please enter the characters that represent a continent.");
    Console.WriteLine("'NA' for North America.");
    Console.WriteLine("'SA' for South America.");
    Console.WriteLine("'A' for Asia.");
    Console.WriteLine("'E' for Europe.");
    Console.WriteLine("'AN' for Antarctica.");
    Console.WriteLine("'AF' for Africa.");
    Console.WriteLine("'O' for Oceania.");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

    string continentCap = Console.ReadLine();
    string continent = continentCap.ToLower();
    Console.WriteLine("");
    ContinentDisplayer(continent);
    Console.WriteLine("");

    while (true)
    {
        Console.WriteLine("Would you like to know information about another continent?");
        Console.WriteLine("Enter 'Yes' or 'No'");
        string yesNoCap = Console.ReadLine();
        string yesNo = yesNoCap.ToLower();
        if (yesNo == "yes" ||  yesNo == "y")
        {
            Console.WriteLine("");
            break;
        }
        else if (yesNo == "no" || yesNo == "n")
        {
            Console.WriteLine("");
            Console.WriteLine("Have a good day!");
            keepConvo = true;
            break;
        }
        else
        {
            Console.WriteLine("Please enter yes or no");
            Console.WriteLine("");
        }
    }
}


void ContinentDisplayer(string a)
{
    if (a == "na")
    {
        Console.WriteLine("There are 23 countries in North America.");
    }
    else if (a == "sa")
    {
        Console.WriteLine("There are 43 countries in South America.");
    }
    else if (a == "a")
    {
        Console.WriteLine("There are 48 countries in Asia.");
    }
    else if (a == "e")
    {
        Console.WriteLine("There are 44 countries in Europe.");
    }
    else if (a == "an")
    {
        Console.WriteLine("There are 0 countries in Antarctica.");
    }
    else if (a == "af")
    {
        Console.WriteLine("There are 54 countries in Africa.");
    }
    else if (a == "o")
    {
        Console.WriteLine("There are 15 countries in Oceania");
    }
    else
    {
        Console.WriteLine("Sorry, there are no continents with that set of charactors");
    }
}
Console.ReadLine();