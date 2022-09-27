using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_MethodsAndObjects5
{
    // Inheriting from Person and including interface IQuittable
    public class Employee:Person, IQuittable
    {
        // properties
        public int Id { get; set; }

        // from interface
        public void Quit(Employee employee)
        {
            Console.WriteLine("\nThe following employee has placed his/her 2 weeks:");
            Console.WriteLine("First name = " + employee.FirstName + " Last name = " + employee.LastName);
        }
        
    }
}
