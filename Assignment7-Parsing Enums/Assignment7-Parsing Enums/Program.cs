using System;

namespace Assignment7_Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 7 - Parsing Enums\n");


            // Prompt the user to enter the current day of the week.
            Console.WriteLine("Enter the current day of the week");

            try
            {
                // Assign the value to a variable of that enum data type you just created.
                var UserInput = Console.ReadLine();

                // Parsing enum... set to ignore cases
                WeekDays weekDay = Enum.Parse<WeekDays>(UserInput, true);

                // Output
                Console.WriteLine("{0} is assigned to enum data type of {1}", UserInput, weekDay);
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the Console open
            Console.ReadLine();


        }

        // Create an enum for the days of the week.
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


    }
}