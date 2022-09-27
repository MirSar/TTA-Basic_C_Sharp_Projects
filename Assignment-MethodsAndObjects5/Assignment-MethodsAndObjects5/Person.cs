using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_MethodsAndObjects5
{
    public abstract class Person
    {
        // Properties of the Class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Void method that simply writes the person's
        // full name in format "Name: [full name]"
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            
        }

    }
}
