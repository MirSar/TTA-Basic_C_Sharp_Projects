using System;
using System.Collections.Generic; // needed for lists
using System.Linq; // Needed for Lambda expressions (Where,etc...)


namespace Assignment8_Lambda_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 8- Lambda funcitons\n");

            // 2. Create a list of at least 10 employees. At least two employees should have the first name “Joe”.

            // a. Creates a List of Employee type         
            List<Employee> EmployeeList = new List<Employee>();

            // b. Creates the Employee objects and adds them to the List.
            EmployeeList.Add(new Employee(01, "Mir", "Sar"));
            EmployeeList.Add(new Employee(02, "Jesse", "Johnson"));
            EmployeeList.Add(new Employee(03, "Joe", "Blow"));
            EmployeeList.Add(new Employee(04, "Sue", "Shoe"));
            EmployeeList.Add(new Employee(05, "Nadine", "Leban"));
            EmployeeList.Add(new Employee(06, "Amber", "Sar"));
            EmployeeList.Add(new Employee(07, "Cari", "TTA"));
            EmployeeList.Add(new Employee(08, "Joe", "Shmoe"));
            EmployeeList.Add(new Employee(09, "Bruce", "Wyane"));
            EmployeeList.Add(new Employee(10, "Hal", "Jordan"));

            Console.WriteLine("This is the full list of employees:");
            Console.WriteLine("--------------------------------------");
            // Loop through the List and print the employee info
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine("Employee: {0} - {1} {2}", employee.Id, employee.FirstName,employee.LastName);
            }

            // 3. Using a foreach loop, create a new list of all employees with the first name “Joe”.         
            List<Employee> NewEmployeeList = new List<Employee>();

            foreach (Employee emp in EmployeeList)
            {
                if (emp.FirstName == "Joe")
                {
                    NewEmployeeList.Add(emp);
                }
            }

            Console.WriteLine("\nSpecific employee list:");
            Console.WriteLine("--------------------------------------");
            // Loop through the List and print the employee info
            foreach (var emp in NewEmployeeList)
            {
                Console.WriteLine("Employee: {0} - {1} {2}", emp.Id, emp.FirstName, emp.LastName);
            }

            // 4. Perform the same action again, but this time with a lambda expression.
            Console.WriteLine("\n Using Lambda expression to list selected employee info:");
            Console.WriteLine("--------------------------------------");

            // One line Lambda expression
            List<Employee> AnotherEmpList = EmployeeList.Where(x => x.FirstName == "Joe").ToList();

            // Loop through the List and print the employee info
            foreach (var emp in AnotherEmpList)
            {
                Console.WriteLine("Employee: {0} - {1} {2}", emp.Id, emp.FirstName, emp.LastName);
            }

            // Keep the Console Open
            Console.ReadLine();

        }
    }
}
