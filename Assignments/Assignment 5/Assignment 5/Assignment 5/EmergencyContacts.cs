using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class EmergencyContacts : EmployeeRecords
    {
        public string FirstName;
        public string LastName;
        public EmergencyContacts()
        {

        }

        public EmergencyContacts(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
