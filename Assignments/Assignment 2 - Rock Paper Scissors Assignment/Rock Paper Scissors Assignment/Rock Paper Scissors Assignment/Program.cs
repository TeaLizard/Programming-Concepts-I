// Owen Williams || Rock Paper Scissors Assignment


//Welcome message
//How many games do you want to play? (for loop)

//Display instructions for rps
//Input rps
//Computer inputs
//Calculate and display winner

//Display current standings

//Play out until game counter is finished
//Finish if there is not a draw, else do a tiebreaker
//Thanks for playing!

Random rnd = new();
int rndNumber;

Console.WriteLine("Welcome to the Rock Paper Scissors Tournament!");
Console.WriteLine("");

Console.WriteLine("How many rounds would you like to play?");
string numberOfGamesString = Console.ReadLine();
int numberOfGames = 0;

while (true)
{
    if (int.TryParse(numberOfGamesString, out numberOfGames) == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("How many rounds would you like to play?");
        numberOfGamesString = Console.ReadLine();
    }
}

if (numberOfGames == 0)
{
    Console.WriteLine("What are you here for then?");
}



int playerWins = 0;
int computerWins = 0;


for (int i = 0; i < numberOfGames; i++)
{
    int rpsOutput = 0;
    bool rpsOnly = false;
    while (rpsOnly == false)
    {
        Console.WriteLine("Input rock, paper, or scissors.");
        string rpsInput = Console.ReadLine();
        string rpsInputLower = rpsInput.ToLower();
        Console.WriteLine("Rock, paper, scissors, DRAW!");

        if (rpsInputLower == "rock" || rpsInputLower == "r") //Legend: 0=rock, 1=paper, 2=scissors.
        {
            rpsOutput = RPS(0);
            rpsOnly = true;
        }
        else if (rpsInputLower == "paper" || rpsInputLower == "p")
        {
            rpsOutput = RPS(1);
            rpsOnly = true;
        }
        else if (rpsInputLower == "scissors" || rpsInputLower == "s")
        {
            rpsOutput = RPS(2);
            rpsOnly = true;
        }
    }
    
    if (rpsOutput == 0)//Win
    {
        playerWins++;
        Console.WriteLine("Player wins!");
    }
    else if (rpsOutput == 1)//Loss
    {
        computerWins++;
        Console.WriteLine("Computer wins!");
    }
    else if (rpsOutput == 2)//Tie
    {
        Console.WriteLine("It's a draw!");
    }

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Standings:");
    Console.WriteLine($"Your score is {playerWins}.");
    Console.WriteLine($"The computer's score is {computerWins}.");
    if (numberOfGames - i - 1 == 1)
    {
        Console.WriteLine("You have 1 round left.");
    }
    else if (numberOfGames - i - 1 == 0)
    {
        //nothing
    }
    else
    {
        Console.WriteLine($"You have {numberOfGames - i - 1} rounds left.");
    }
    Console.WriteLine("");
    Console.WriteLine("");
}



while (playerWins == computerWins && numberOfGames != 0)
{
    Console.WriteLine("Tiebreaker!!");

    int rpsOutput = 0;
    bool rpsOnly = false;
    while (rpsOnly == false)
    {
        Console.WriteLine("Input rock, paper, or scissors.");
        string rpsInput = Console.ReadLine();
        string rpsInputLower = rpsInput.ToLower();
        Console.WriteLine("Rock, paper, scissors, DRAW!");

        if (rpsInputLower == "rock" || rpsInputLower == "r") //Legend: 0=rock, 1=paper, 2=scissors.
        {
            rpsOutput = RPS(0);
            rpsOnly = true;
        }
        else if (rpsInputLower == "paper" || rpsInputLower == "p")
        {
            rpsOutput = RPS(1);
            rpsOnly = true;
        }
        else if (rpsInputLower == "scissors" || rpsInputLower == "s")
        {
            rpsOutput = RPS(2);
            rpsOnly = true;
        }
    }

    if (rpsOutput == 0)//Win
    {
        playerWins++;
        Console.WriteLine("Player wins!");
    }
    else if (rpsOutput == 1)//Loss
    {
        computerWins++;
        Console.WriteLine("Computer wins!");
    }
    else if (rpsOutput == 2)//Tie
    {
        Console.WriteLine("It's a draw!");
    }

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Standings:");
    Console.WriteLine($"Your score is {playerWins}.");
    Console.WriteLine($"The computer's score is {computerWins}.");
    Console.WriteLine("");
    Console.WriteLine("");
}

if(numberOfGames != 0)
{
    if (playerWins > computerWins)
    {
        Console.WriteLine("The series winner is the player!");
    }
    else
    {
        Console.WriteLine("The series winner is the computer!");
    }

    Console.WriteLine("Thank you for playing!");
}





int RPS(int a)//Legend for output: 0=win, 1=loss, 2=tie.
{
    rndNumber = rnd.Next(3);
    if (rndNumber == 0 && a == 1)//a=playerInput
    {
        Console.WriteLine("Player chose paper.");
        Console.WriteLine("Computer chose rock.");
        return 0;
    }
    else if (rndNumber == 0 && a == 2)
    {
        Console.WriteLine("Player chose scissors.");
        Console.WriteLine("Computer chose rock.");
        return 1;
    }
    else if (rndNumber == 1 && a == 2)
    {
        Console.WriteLine("Player chose scissors.");
        Console.WriteLine("Computer chose paper.");
        return 0;
    }
    else if (rndNumber == 1 && a == 0)
    {
        Console.WriteLine("Player chose rock.");
        Console.WriteLine("Computer chose paper.");
        return 1;
    }
    else if (rndNumber == 2 && a == 0)
    {
        Console.WriteLine("Player chose rock.");
        Console.WriteLine("Computer chose scissors.");
        return 0;
    }
    else if (rndNumber == 2 && a == 1)
    {
        Console.WriteLine("Player chose paper.");
        Console.WriteLine("Computer chose scissors.");
        return 1;
    }
    else if (a == 0)
    {
        Console.WriteLine("Both chose rock!");
        return 2;
    }
    else if (a == 1)
    {
        Console.WriteLine("Both chose paper!");
        return 2;
    }
    else if (a == 2)
    {
        Console.WriteLine("Both chose scissors!");
        return 2;
    }
    else
    {
        return 3;
    }
}

Console.ReadLine();