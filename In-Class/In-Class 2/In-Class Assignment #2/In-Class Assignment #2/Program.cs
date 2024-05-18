//Owen Williams || In-Class Assignment #2


//ask number of students.
//for number of students ask each if they are international, and which sports they play
//display results



using System.Numerics;

Console.WriteLine("How many students are in your class?");
string numberOfStudentsString = Console.ReadLine();
int numberOfStudents = int.Parse(numberOfStudentsString);
Console.WriteLine($"You have {numberOfStudents} students.");

int basketball = 0;

int baseball = 0;
int soccar = 0;
int football = 0;
int international = 0;
int currentStudent = 1;
while (currentStudent <= numberOfStudents)
{
    Console.WriteLine($"Student #{currentStudent}:");

    bool basketballConvo = false;
    while (basketballConvo == false)
    {
        Console.WriteLine("Do you play basketball?");

        string yesOrNo = Console.ReadLine();
        if (YesNoCheck(yesOrNo) == true)
        {
            if (YesNo(yesOrNo) == true)
            {
                basketball++;
                basketballConvo = true;
            }
            else
            {
                basketballConvo = true;
            }
        }
    }

    soccar = SportQuestion(soccar, "soccar");
    baseball = SportQuestion(baseball, "baseball");
    football = SportQuestion(football, "football");

    bool internationalConvo = false;
    while (internationalConvo == false)
    {
        Console.WriteLine("Are you an international student?");

        string yesOrNo = Console.ReadLine();
        if (YesNoCheck(yesOrNo) == true)
        {
            if (YesNo(yesOrNo) == true)
            {
                international++;
                internationalConvo = true;
            }
            else
            {
                internationalConvo = true;
            }
        }
    }


    currentStudent++;
}

Console.WriteLine($"Total students: {numberOfStudents}.");
Console.WriteLine($"Total international students: {international}.");
Console.WriteLine($"Total students that play basketball: {basketball}.");
Console.WriteLine($"Total students that play soccar: {soccar}.");
Console.WriteLine($"Total students that play baseball: {baseball}.");
Console.WriteLine($"Total students that play football: {football}.");





Console.ReadLine();

bool YesNoCheck(string a)
{
    string b = a.ToLower();
    if (b == "yes" ||  b == "no" || b == "y" || b == "n")
    {
        return true;
    }
    else
    {
        Console.WriteLine("Please enter yes or no");
        return false;
    }
}
bool YesNo(string a)
{
    string b = a.ToLower();
    bool c;

    if (b == "yes" || b == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
    
}

int SportQuestion(int a, string b)
{
    bool sportConvo = false;
    while (sportConvo == false)
    {
        Console.WriteLine($"Do you play {b}?");

        string yesOrNo = Console.ReadLine();
        if (YesNoCheck(yesOrNo) == true)
        {
            if (YesNo(yesOrNo) == true)
            {
                sportConvo = true;
                a++;
                return a;
            }
            else
            {
                sportConvo = true;
                return a;
            }
        }
    }
    return 0;
}