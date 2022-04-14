using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenance
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        Customer()
        {

        }
        Customer(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public string GetDisplayText => 
            FirstName + " " + 
            LastName + ", " + Email;


/*        string GetDisplayText()
        {
            return "";
        }*/

    }
}
