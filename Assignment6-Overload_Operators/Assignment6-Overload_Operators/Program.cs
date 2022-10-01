using System;

namespace Assignment6_Overload_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment6 Operators overload");

            // Instantiation: Creating new Empoyee object
            // Initializing: Assigning values
            Employee DevOpEmployee1 = new Employee()
            {
                FirstName = "Mir",
                LastName = "Sar",
                Id = 001,
            };
            Employee DevOpEmployee2 = new Employee()
            {
                FirstName = "Jesse",
                LastName = "TTA",
                Id = 002,
            };
            Employee DevOpEmployee3 = new Employee()
            {
                FirstName = "John",
                LastName = "Smith",
                Id = 001,
            };

            // Using Overloaded Operators
            Console.WriteLine("\nDo these two employee's have the same Id's assigned to them?");
            bool IdChecked = DevOpEmployee1.Id == DevOpEmployee2.Id;
            bool IdChecked2 = DevOpEmployee1.Id == DevOpEmployee3.Id;

            // Checking the Overloaded != operator
            bool IdChecked3 = DevOpEmployee1.Id != DevOpEmployee2.Id;
            bool IdChecked4 = DevOpEmployee1.Id != DevOpEmployee3.Id;


            Console.WriteLine("{0} and {1} have the same Id: {2}", DevOpEmployee1.FirstName, DevOpEmployee2.FirstName, IdChecked);
            Console.WriteLine("{0} and {1} have the same Id: {2}", DevOpEmployee1.FirstName, DevOpEmployee3.FirstName, IdChecked2);

            Console.WriteLine("\nDo these two employee's have different Id's assigned to them?");

            Console.WriteLine("{0} and {1} have different Id's: {2}", DevOpEmployee1.FirstName, DevOpEmployee2.FirstName, IdChecked3);
            Console.WriteLine("{0} and {1} have different Id's: {2}", DevOpEmployee1.FirstName, DevOpEmployee3.FirstName, IdChecked4);

            // Keep the Console Open
            Console.ReadLine();



        }
    }
}
