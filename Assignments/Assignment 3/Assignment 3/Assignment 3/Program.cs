// Owen Williams || Assignment 3


using System.Reflection.Metadata.Ecma335;

double totalCost = 0;
double cashAmount = 0;




Console.WriteLine("Welcome to the checkout!");
Console.WriteLine("");

bool stillItemsBool = false;
while (stillItemsBool == false)
{
    Console.WriteLine("What is the name of your item?");
    Console.WriteLine("");
    string item = Console.ReadLine();
    Console.WriteLine("");

    while (true) // TryParse loop
    {
        Console.WriteLine("What is the price of your item in dollars?");
        Console.WriteLine("");
        string priceString = Console.ReadLine();
        Console.WriteLine("");
        if (double.TryParse(priceString, out double price))
        {
            Console.WriteLine($"Your item is {item} and the price is {price:C}.");

            totalCost += price;
            Console.WriteLine($"Your total is {totalCost:C}.");
            Console.WriteLine("");

            break;
        }
        else
        {
            Console.WriteLine("Please reply with just a number, no dollar sign.");
            Console.WriteLine("");
        }
    }

    while (true) // Yes, No, or Error.
    {
        Console.WriteLine("Do you have any more items to ring up?");
        Console.WriteLine("");

        string stillItemsStringUpper = Console.ReadLine();
        string stillItemsString = stillItemsStringUpper.ToLower();
        Console.WriteLine("");

        if (stillItemsString == "y" || stillItemsString == "yes")
        {
            break;
        }
        else if (stillItemsString == "n" || stillItemsString == "no")
        {
            stillItemsBool = true;
            break;
        }
        else
        {
            Console.WriteLine("Please reply with a yes or no.");
            Console.WriteLine("");
        }
    }
}

bool cashOrCardConvoBool = false;
while (cashOrCardConvoBool == false)
{
    Console.WriteLine("Will you be paying with cash or card; or will you be forfeiting your items?");
    Console.WriteLine("");

    string cashOrCardStringUpper = Console.ReadLine();
    string cashOrCardString = cashOrCardStringUpper.ToLower();
    Console.WriteLine("");

    if (cashOrCardString == "cash")
    {
        while (true) // TryParse loop
        {
            Console.WriteLine("Please enter your cash amount.");
            Console.WriteLine("");

            string cashAmountString = Console.ReadLine();
            Console.WriteLine("");

            if (double.TryParse(cashAmountString, out cashAmount) && totalCost > cashAmount)
            {
                Console.WriteLine("You have insufficient funds.");
                Console.WriteLine("");
                break;
            }
            else if (double.TryParse(cashAmountString, out cashAmount))
            { 
                HaveAGoodDay("cash");
                cashOrCardConvoBool = true;
                break;
            }
            else
            {
                Console.WriteLine("Please reply with just a number, no dollar sign.");
                Console.WriteLine("");
            }
        }
    }
    else if (cashOrCardString == "card")
    {
        while (true) // Correct, incorrect, or Error
        {
            Console.WriteLine("Please enter card info.");
            Console.WriteLine("(Type valid or declined)");
            Console.WriteLine("");

            string cardCorrectStringUpper = Console.ReadLine();
            string cardCorrectString = cardCorrectStringUpper.ToLower();
            Console.WriteLine("");

            if (cardCorrectString == "valid" || cardCorrectString == "v")
            {
                HaveAGoodDay("card");
                cashOrCardConvoBool = true;
                break;
            }
            else if (cardCorrectString == "declined" || cardCorrectString == "d")
            {
                Console.WriteLine("Your card was declined.");
                Console.WriteLine("");
                break;
            }
            else
            {
                Console.WriteLine("Please enter 'correct' or 'declined'.");
                Console.WriteLine("");
            }
        }
    }
    else if (cashOrCardString == "forefeiting" || cashOrCardString == "forefeit" || cashOrCardString == "f")
    {
        HaveAGoodDay("neither");
        break;
    }
    else
    {
        Console.WriteLine("Please reply with cash, card, or forfeit.");
        Console.WriteLine("");
    }


}

Console.ReadLine();

void HaveAGoodDay(string a)
{
    if (a == "cash")
    {
        if (totalCost == cashAmount) // Exact change
        {
            Console.WriteLine($"Exact change! Your total is {totalCost:C}.");
            Console.WriteLine($"");
        }
        else if (totalCost > cashAmount) // Not enough money
        {
            // Error
        }
        else // More than enough (Change)
        {
            double change = cashAmount - totalCost;
            Console.WriteLine($"Your total is {totalCost:C}, Your change is {change:C}.");
            Console.WriteLine($"");
        }
    }
    else if (a == "card")
    {
        Console.WriteLine($"Your total is {totalCost:C}.");
        Console.WriteLine($"");
    }
    else // Not buying
    {
         // No additional dialogue
    }
    
    Console.WriteLine($"Have a good day!");
    Console.WriteLine($"");
}