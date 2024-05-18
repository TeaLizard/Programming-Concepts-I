// Owen Williams || Assignment 5 


namespace Assignment_5
{
    public class Program
    {
        public static EmployeeRecords Employee;
        public static void Main()
        {
            
            while (Menu());

            Console.WriteLine("Have a good day!\n");
        }

        public static bool Menu()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("A. Add a new Employee.\r\nB. Edit the only existing Employee record.\r\nC. Display the first name, last name, monthly salary (if one already exists), and a list of emergency\r\ncontacts (first name and last name) for the respective employee\r\nD. Exit the program\n");
                    string menuAnswer = Console.ReadLine().Trim().ToLower();
                    Console.WriteLine("");

                    if (menuAnswer == "a" || menuAnswer == "add" || menuAnswer == "new")
                    {
                        EmployeeRecords.AddEmployee();
                        return true;
                    }
                    else if (menuAnswer == "b" || menuAnswer == "edit")
                    {
                        EmployeeRecords.EditEmployee();
                        return true;
                    }
                    else if (menuAnswer == "c" || menuAnswer == "display")
                    {
                        EmployeeRecords.DisplayEmployees();
                        return true;
                    }
                    else if (menuAnswer == "d" || menuAnswer == "exit")
                    {
                        return false;
                    }
                    else
                    {
                        throw new Exception("Input not recognised.\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }
        }
    }
}





