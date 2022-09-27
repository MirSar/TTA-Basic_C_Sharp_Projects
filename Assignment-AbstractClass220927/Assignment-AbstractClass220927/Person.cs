using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_AbstractClass220927
{
    // This is an abstract class
    public abstract class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Methods
        public static void SayName()
        {
            Console.WriteLine(FirstName+" "+ LastName);
        }

    }
}
