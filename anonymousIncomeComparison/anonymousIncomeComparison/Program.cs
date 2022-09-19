using System;

namespace anonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("*************************************");

            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate?");
            string ip1HourlyRate = Console.ReadLine();
            double p1HourlyRate = Convert.ToDouble(ip1HourlyRate);

            Console.WriteLine("Hours worked per week?");
            string ip1HoursWorked = Console.ReadLine();
            double p1HoursWorked = Convert.ToDouble(ip1HoursWorked);
            
            // For person 2
            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate?");
            string ip2HourlyRate = Console.ReadLine();
            double p2HourlyRate = Convert.ToDouble(ip2HourlyRate);

            Console.WriteLine("Hours worked per week?");
            string ip2HoursWorked = Console.ReadLine();
            double p2HoursWorked = Convert.ToDouble(ip2HoursWorked);

            // Calculate annual salary of Persons
            double p1AnnualSalary = (52 * p1HoursWorked) * p1HourlyRate;
            double p2AnnualSalary = (52 * p2HoursWorked) * p2HourlyRate;
            bool higherSalary = (p1AnnualSalary > p2AnnualSalary);
            // Console output
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(p1AnnualSalary);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(p2AnnualSalary);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(higherSalary);

            // keep the console app open
            Console.ReadLine();
        }
    }
}
