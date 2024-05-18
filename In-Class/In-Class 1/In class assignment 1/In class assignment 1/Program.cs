//In class assignment 1

//Client name, total area to be paved, estimate of the driveway, cost per square feet, total cost before tax, cost after tax, you're a valued customer!!


using System.Formats.Asn1;

Console.WriteLine("Conestoga Paving Company");
Console.WriteLine("Current rate ~ $18.53 per square foot");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

Console.WriteLine("What is your name?");

string name = Console.ReadLine();

Console.WriteLine($"{name} what is the length of your driveway in feet?");

string lengthString = Console.ReadLine();
decimal length = decimal.Parse( lengthString );

Console.WriteLine($"Okay, what is the width of your driveway in feet?");

string widthString = Console.ReadLine();
decimal width = decimal.Parse( widthString );

decimal area = length * width;

decimal costBeforeTax = 18.53m * area;

decimal costAfterTax = costBeforeTax * 1.13m;

Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

Console.WriteLine($"Your estimate for paving the driveway:");
Console.WriteLine($"Client name: {name}.");
Console.WriteLine($"Total area to be paved: {area}:");
Console.WriteLine($"Our cost per square foot: $18.53.");
Console.WriteLine($"Your cost before tax: {costBeforeTax.ToString("C")}.");
Console.WriteLine($"Your cost after tax: {costAfterTax.ToString("C")}.");
Console.WriteLine($"You're a valued customer {name}! Have a great day!");







