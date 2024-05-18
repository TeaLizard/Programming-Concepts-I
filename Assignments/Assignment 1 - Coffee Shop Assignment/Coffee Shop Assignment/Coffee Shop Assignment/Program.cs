//Coffee Shop Assignment | Owen Williams

Console.WriteLine("Menu for Conestoga Coffee");
Console.WriteLine("Coffees are $2.00");
Console.WriteLine("Doughnuts are $1.00");
Console.WriteLine("Soft drinks are $1.75");
Console.WriteLine("We have a coffee card system for 10% off all purchases!");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("");
Console.WriteLine("Hello, Welcome to Conestoga coffee!");
Console.WriteLine("We are committed to serving our comunity at a reasonable price!");
Console.WriteLine("I hope we can brighten your day with a coffee, doughnut or soft drink!");
Console.WriteLine(""); //Menu





bool coffeeConvo1 = false;
bool coffeeynBool = false;

while (coffeeConvo1 == false) //It has to be a yes or no
{

    Console.WriteLine("Would you like any coffee today?");

    string coffeeyn = Console.ReadLine();
    string coffeeynLower = coffeeyn.ToLower();

    if (coffeeynLower == "Yes" || coffeeynLower == "yes") //I realize there is redundancy here, I did not origionally use .ToLower()
    {
        coffeeConvo1 = true;
        coffeeynBool = true;
    }

    else if (coffeeynLower == "no" || coffeeynLower == "No")
    {
        coffeeConvo1 = true;
        coffeeynBool = false;
        Console.WriteLine("You would not like any coffee.");
    }

    else
    {
        Console.WriteLine("I'm sorry, please reply again with a yes or no.");
    }

}

bool coffeeConvo2 = false;
int coffeeNumber = 0;


if (coffeeynBool == true) //If they want some coffee
{
    while (coffeeConvo2 == false) //For syntax error, numbers only
    {
        Console.WriteLine("How many coffees would you like?");

        string coffeeNumberString = Console.ReadLine(); //Input how many coffees

        if (int.TryParse(coffeeNumberString, out coffeeNumber) == true)
        {
            Console.WriteLine($"You would like {coffeeNumber} coffees.");
            coffeeConvo2 = true;
        }
        else
        {
            Console.WriteLine("Please reply again with a number");
            coffeeConvo2 = false;
        }
    }
}

//while (coffeeConvo2 == false) //For syntax error, may not finish this part
//{
//    Console.WriteLine("How many coffees would you like?");

//    string coffeeNumberString = Console.ReadLine(); //Input how many coffees

//    coffeeNumber = int.Parse(coffeeNumberString); //Parse that input

//    Console.WriteLine($"You would like {coffeeNumber} coffees.");
//    coffeeConvo2 = true;

//}

Console.WriteLine("Do you want any doughnuts?");

bool doughnutConvo1 = false;
string doughnutsynString = Console.ReadLine(); //Input if you want doughnuts or not
string doughnutsynStringLower = doughnutsynString.ToLower();
bool doughnutsynBool = false;

while (doughnutConvo1 == false) //Has to be yes or no
{
    if (doughnutsynStringLower == "yes" ||  doughnutsynStringLower == "Yes") //Yes doughnuts
    {
        doughnutsynBool = true;
        doughnutConvo1 = true;
    }

    else if (doughnutsynStringLower == "no" || doughnutsynStringLower == "No") //No doughnuts
    {
        doughnutsynBool = false;
        doughnutConvo1 |= true;
    }

    else //Did not reply properly
    {
        Console.WriteLine("Please answer again with a yes or no.");
    }
}

int doughnutNumber = 0;
bool doughnutConvo2 = false; 

if (doughnutsynBool == true) //If they want some doughnuts
{
    while (doughnutConvo2 == false) //For syntax error, numbers only
    {
        Console.WriteLine("How many doughnuts would you like?");

        string doughnutNumberString = Console.ReadLine(); //Input how many doughnuts

        if (int.TryParse(doughnutNumberString, out doughnutNumber) == true)
        {
            Console.WriteLine($"You would like {doughnutNumber} doughnuts.");
            doughnutConvo2 = true;
        }
        else
        {
            Console.WriteLine("Please reply again with a number");
            doughnutConvo2 = false;
        }
    }
}

//if (doughnutsynBool == true) //If they want doughnuts
//{
//    Console.WriteLine("How many doughnuts do you want?");

//    string doughnutNumberString = Console.ReadLine();
//    doughnutNumber = int.Parse(doughnutNumberString); //How many doughnuts as an int

//    Console.WriteLine($"You would like {doughnutNumber} doughnuts.");
//}

bool softDrinkConvo1 = false;
bool softDrinkynBool = false;

while (softDrinkConvo1 == false)
{
Console.WriteLine("Would you like a soft drink?"); //Do they want a soft drink?
string softDrinkynString = Console.ReadLine();
string softDrinkynStringLower = softDrinkynString.ToLower();


    if (softDrinkynStringLower == "yes")
    {
        softDrinkynBool = true;
        softDrinkConvo1 = true;
    }

    else if (softDrinkynStringLower == "no")
    {
        softDrinkynBool = false;
        softDrinkConvo1 = true;
    }

    else
    {
        Console.WriteLine("Please reply again with yes or no.");
    }
}

int softDrinkNumber = 0;
bool softDrinkConvo2 = false;

if (softDrinkynBool == true) //If they want soft drink(s)
{
    while (softDrinkConvo2 == false) //For syntax error, numbers only
    {
        Console.WriteLine("How many soft drinks would you like?");

        string softDrinkNumberString = Console.ReadLine(); //Input how many soft drinks

        if (int.TryParse(softDrinkNumberString, out softDrinkNumber) == true)
        {
            Console.WriteLine($"You would like {softDrinkNumber} soft drinks.");
            softDrinkConvo2 = true;
        }
        else
        {
            Console.WriteLine("Please reply again with a number");
            softDrinkConvo2 = false;
        }
    }
}

//if (softDrinkynBool == true) //How many drinks?
//{
//    Console.WriteLine("How many soft drinks would you like?");
//    string softDrinkNumberString = Console.ReadLine();
//    softDrinkNumber = int.Parse(softDrinkNumberString);
//    Console.WriteLine($"You would like {softDrinkNumber} soft drinks.");
//}


Console.WriteLine("Do you have a Conestoga Coffee card for 10% off?");

string cardynString = Console.ReadLine();
bool cardConvo = false;
bool cardynBool = false;

while (cardConvo == false) //Yes and no only
{
    if (cardynString == "yes" || cardynString == "Yes") //If they have a card
    {
        cardynBool = true;
        cardConvo = true;
        Console.WriteLine("Great!");
    }

    else if (cardynString == "no" || cardynString == "No")
    {
        cardynBool = false;
        cardConvo = true;
        Console.WriteLine("No problem!");
    }

    else
    {
        Console.WriteLine("Please reply again with a yes ot no.");
        Console.WriteLine("Do you have a Conestoga Coffee card for 10% off?");
        cardynString = Console.ReadLine();
    }
}

Console.WriteLine("");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("This is your Conestoga coffee receipt!");

decimal coffeeCost = 0;
decimal doughnutsCost = 0;
decimal softDrinkCost = 0;

if (coffeeynBool == true)
{
    coffeeCost = 2m * coffeeNumber;
    Console.WriteLine($"Your coffee total is {coffeeCost.ToString("C")} for {coffeeNumber} coffees");
}

if (doughnutsynBool == true)
{
    doughnutsCost = 1m * doughnutNumber;
    Console.WriteLine($"Your doughnut total is {doughnutsCost.ToString("C")} for {doughnutNumber} doughnuts");
}

if (softDrinkynBool == true)
{
    softDrinkCost = 1.75m * softDrinkNumber;
    Console.WriteLine($"Your soft drink total is {softDrinkCost.ToString("C")} {softDrinkNumber} soft drinks");
}

decimal total = coffeeCost + doughnutsCost + softDrinkCost;
decimal totalCard = 0;
decimal totalTax = 0;
decimal tax = 0;


if (cardynBool == true)
{
    totalCard = total * 0.9m;
    Console.WriteLine($"Before taxes, your total before savings is {total.ToString("C")} and your total after savings is {totalCard.ToString("C")}");
    Console.WriteLine($"You saved {(total * 0.1m).ToString("C")}");
}

else
{
    Console.WriteLine($"Your total before taxes is {total}");
}

if (cardynBool == true)
{
    totalTax = totalCard * 1.13m;
    tax = totalCard * 0.13m;
}
else
{
    totalTax = total * 1.13m;
    tax = total * 0.13m;
}
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

Console.WriteLine($"Your total after tax is {totalTax.ToString("C")}");
Console.WriteLine($"Your tax amount is {tax.ToString("C")}");

Console.WriteLine("Thank you for shopping at Conestoga Coffee!");

if (cardynBool == false)
{
    Console.WriteLine("Consider signing up for a savings card for 10% off all purchases!");
}


















