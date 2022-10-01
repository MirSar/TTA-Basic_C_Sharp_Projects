using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_Overload_Operators
{
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading Operators: overload the “==” operator so it checks if two Employee objects
        // are equal by comparing their Id property.
        public static bool operator== (Employee Id1, Employee Id2)
        {
            bool status = false;
            if (Id1 == Id2)
            {
                status = true;
                return status;
            }
            
            return status;                   
        }

        // Comparison operators must be overloaded in pairs.
        public static bool operator!= (Employee Id1, Employee Id2)
        {
            bool status = false;
            if (Id1 != Id2)
            {
                status = true;
                return status;
            }
            return status;        
        }

    }
}
