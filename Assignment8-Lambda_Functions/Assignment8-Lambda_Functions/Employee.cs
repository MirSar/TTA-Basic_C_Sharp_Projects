using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment8_Lambda_Functions
{
    public class Employee
    {
        // Creating a constructor
        public Employee(int Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Methods

    }
}
