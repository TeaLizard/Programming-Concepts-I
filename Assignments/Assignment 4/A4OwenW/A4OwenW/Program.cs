// Owen Williams || Assignment 4

// I'm not sure what you meant by "Your header comment is to follow the P4 standard in IT Standards."


using System.Globalization;



namespace A4OwenW
{
    public class Program
    {
        protected static bool EndGame = false;
        
        public static void Main()
        {
            Console.WriteLine("Swords&Staffs");
            Console.WriteLine("");

            while (EndGame == false)
            {
                GameMenu.Menu();
            }

            Console.WriteLine("Have a great day!");
            Console.ReadLine();
        }
    }
}





