using System;

namespace Assignment_MethodsAndObjects5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment Methods and Objects submission\n");

            // Instantiate and initilizing Employee object
            Employee employeeOne = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
            };

            // Calling the superclass method
            employeeOne.SayName();

            // Keep the Console Open
            Console.ReadLine();

        }
    }
}
