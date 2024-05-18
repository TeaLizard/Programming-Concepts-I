using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass5
{
    public class Login
    {
        private string Username;
        private string Password;
        public Login()
        {
            Console.WriteLine("Please enter your username");
            Console.WriteLine("");
            Username = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Please enter your password");
            Console.WriteLine("");
            Password = Console.ReadLine();
            Console.WriteLine("");

            while (CheckUsername() == false)
            {
                Console.WriteLine("Incorrect username format! Username must be at least 6 characters long!");
                Console.WriteLine("");
                Username = Console.ReadLine();
                Console.WriteLine("");
            }

            while (CheckPassword() == false)
            {
                Console.WriteLine("Incorrect password format! Password must be 8 characters long!");
                Console.WriteLine("");
                Password = Console.ReadLine();
                Console.WriteLine("");
            }

            Console.WriteLine("Login successful.");
            Console.WriteLine("");
        }
        private bool CheckUsername()
        {
            if (Username == null || Username.Length < 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CheckPassword()
        {
            if (Password == null || Password.Length != 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void DisplayUsername()
        {
            Console.WriteLine(Username);
        }
        private void DisplayPassword()
        {
            Console.WriteLine(Password);
        }
        private string ReturnUsername()
        {
            return Username;
        }
        private string ReturnPassword()
        {
            return Password;
        }
    }
}
