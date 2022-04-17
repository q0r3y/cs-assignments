using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenance
{
    public struct Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Customer(string firstName, string lastName, string email) =>
            (this.FirstName, this.LastName, this.Email) = (firstName, lastName, email);

        public string GetDisplayText => 
            FirstName + " " + LastName + ", " + Email;
    }
}
