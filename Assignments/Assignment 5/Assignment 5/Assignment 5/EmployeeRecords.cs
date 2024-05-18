using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_5
{
    public class EmployeeRecords : Program
    {
        public int EmployeeId;
        public string EmployeeFirstName;
        public string EmployeeLastName;
        public double MonthlySalary;
        public static bool HasBeenAdded = false;
        public List<EmergencyContacts> EmergencyContactList;
        public EmployeeRecords()
        {

        }

        public EmployeeRecords(int id, string name, double monthlySalary, EmergencyContacts emergencyContact)
        {
            EmployeeId = id;
            EmployeeFirstName = name;
            MonthlySalary = monthlySalary;
            EmergencyContactList.Add(emergencyContact);
        }
        public EmployeeRecords(int id, string firstName, string lastName, double monthlySalary)
        {
            EmployeeId = id;
            EmployeeFirstName = firstName;
            EmployeeLastName = lastName;
            MonthlySalary = monthlySalary;
            EmergencyContactList = new List<EmergencyContacts>();
        }

        public EmployeeRecords(int id, string name)
        {
            EmployeeId = id;
            EmployeeFirstName = name;
        }

        public static void AddEmployee()
        {
            string employeeLastName; string employeeFirstName = WhatIsYourName(out employeeLastName);
            int id = WhatIsYourId();
            double monthlySalary = WhatIsYourMonthlySalary();
            string lastName; string firstName = WhatAreYourEmergencyContacts(out lastName);

            Employee = new EmployeeRecords(id, employeeFirstName, employeeLastName, monthlySalary);
            Employee.EmergencyContactList.Add(new(firstName, lastName));
            HasBeenAdded = true;
        }

        public static void EditEmployee()
        {
            string whatToEdit;
            bool whatToEditBool = true;
            while (whatToEditBool)
            {
                try
                {
                    Console.WriteLine("What do you want to edit?\n\nA. Name\nB. ID\nC. Monthly Salary\nD. Emergency Contacts\n");
                    whatToEdit = Console.ReadLine().Trim().ToLower();
                    Console.WriteLine("");

                    if (whatToEdit == "a" || whatToEdit == "name")
                    {
                        Employee.EmployeeFirstName = WhatIsYourName(out string lastName);
                        Employee.EmployeeLastName = lastName;
                    }
                    else if (whatToEdit == "b" || whatToEdit == "id")
                    {
                        Employee.EmployeeId = WhatIsYourId();
                    }
                    else if (whatToEdit == "c" || whatToEdit == "monthly salary" || whatToEdit == "salary")
                    {
                        Employee.MonthlySalary = WhatIsYourMonthlySalary();
                    }
                    else if (whatToEdit == "d" || whatToEdit == "emergency contacts" || whatToEdit == "contacts" || whatToEdit == "contact")
                    {
                        Employee.EmergencyContactList.Add(new(WhatAreYourEmergencyContacts(out string lastName), lastName));
                    }
                    else
                    {
                        throw new Exception("Invalid input.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void DisplayEmployees()
        {
            if (HasBeenAdded)
            {
                Console.WriteLine($"Name: {Employee.EmployeeFirstName} {Employee.EmployeeLastName}\nID: {Employee.EmployeeId}\nMonthly Salary: {Employee.MonthlySalary.ToString("C")}\n");
                foreach (EmergencyContacts contact in Employee.EmergencyContactList)
                {
                    Console.WriteLine($"{contact.FirstName} {contact.LastName}");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Employee has not been added yet.");
            }
        }
        public static int WhatIsYourId()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("What is your id?\n");
                    int employeeId = int.Parse(Console.ReadLine().Trim());
                    Console.WriteLine("");

                    if (HasBeenAdded)
                    {
                        if (employeeId == Employee.EmployeeId)
                        {
                            Console.WriteLine("An employee already had this ID.\n");
                        }
                        else
                        {
                            return employeeId;
                        }
                    }
                    else
                    {
                        return employeeId;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message + "\n");
                }
            }
            
        }

        public static string WhatIsYourName(out string employeeLastName)
        {
            string name = "";
            bool firstNameBool = true;
            while (firstNameBool)
            {
                try
                {
                    Console.WriteLine("What is your first name?\n");
                    name = Console.ReadLine().Trim();
                    Console.WriteLine("");

                    if (int.TryParse(name, out _))
                    {
                        throw new FormatException("Enter a name not a number.");
                    }
                    else if (double.TryParse(name, out _))
                    {
                        throw new FormatException("Enter a name not a number.");
                    }
                    else if (name == null || name == "")
                    {
                        throw new Exception("Enter a name.");
                    }
                    else if (HasBeenAdded)
                    {
                        if (Employee.EmployeeFirstName.ToLower() == name.ToLower())
                        {
                            throw new Exception("Employee already exsists.");
                        }
                    }
                    else
                    {
                        firstNameBool = false;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n" + ex.Message + "\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("What is your last name?\n");
                    employeeLastName = Console.ReadLine().Trim();
                    Console.WriteLine("");

                    if (int.TryParse(employeeLastName, out _))
                    {
                        throw new FormatException("Enter a name not a number.");
                    }
                    else if (double.TryParse(employeeLastName, out _))
                    {
                        throw new FormatException("Enter a name not a number.");
                    }
                    else if (employeeLastName == null || employeeLastName == "")
                    {
                        throw new Exception("Enter a name.");
                    }
                    else if (HasBeenAdded)
                    {
                        if (Employee.EmployeeLastName.ToLower() == employeeLastName.ToLower())
                        {
                            throw new Exception("Employee already exsists.");
                        }
                    }
                    else
                    {
                        return name;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n" + ex.Message + "\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }
        }
        public static double WhatIsYourMonthlySalary()
        {
            double monthlySalary = 0;
            bool salaryBool = true;
            while (salaryBool)
            {
                try
                {
                    Console.WriteLine("What is your monthly salry?\n(Only enter the number and not the dollar sign.)\n");
                    monthlySalary = double.Parse(Console.ReadLine().Trim());
                    Console.WriteLine("");
                    salaryBool = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message + "\n");
                }
            }
            

            return monthlySalary;
        }

        public static string WhatAreYourEmergencyContacts(out string lastName)
        {
            Console.WriteLine("What is your contact's first name?\n");
            string firstName = Console.ReadLine().Trim();
            Console.WriteLine("");

            Console.WriteLine("What is your contact's last name?\n");
            lastName = Console.ReadLine().Trim();
            Console.WriteLine("");

            return firstName;
        }
    }
}
