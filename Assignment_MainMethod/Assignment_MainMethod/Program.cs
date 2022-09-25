using System;

namespace Assignment_MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("Main Method Submission Assignment");
            Console.WriteLine("**************************************\n");
            Console.WriteLine("You visit UK and someone says they weigh x number of stones?\n" +
                "Let's make some sense of that and convert it to pounds\n");

            // Creating a class object to access our methods
            MathOperations mathOperations = new MathOperations();

            // User Input

            try
            {
                // For method 1
                Console.Write("How many Stones you say (whole number)? >>> ");
                int stonesInt = Convert.ToInt32(Console.ReadLine());

                // For method 2
                Console.Write("Now give me pounds (decimal number) and I'll tell you how many stones it is? >>> ");
                decimal poundsDecimal = Convert.ToDecimal(Console.ReadLine());


                // Calling our methods
                int convertedTolbs = mathOperations.stoneTolbs(stonesInt);
                int convertedToStonesDecimal = mathOperations.stoneTolbs(poundsDecimal);

                // Output
                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("{0} stones is equal to {1} pounds (rounded to nearest integer)", stonesInt, convertedTolbs);
                Console.WriteLine("{0} pounds is equal to {1} stones (rounded to nearest integer)", poundsDecimal, convertedToStonesDecimal);
                Console.WriteLine("___________________________________________________________");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter the correct datatype for your entery");
            }
            finally
            {
                //keep the console open
                Console.ReadLine();
            }


            // Calling in the third method
            Console.WriteLine("Give me a number and I will add it to a Random number\n" +
                "giving you the total. ");
            string userInput = Console.ReadLine();
            try
            {
                // random number
                

                // calling the method
                int total = mathOperations.stoneTolbs(userInput, out int randNum);

                // output
                Console.WriteLine("your number {0} plus a random number = {1}", userInput, total);
                Console.WriteLine("What is the random number?");
                Console.ReadLine();
                Console.WriteLine("The random number added is = {0}", randNum);
                

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            





        }
    }
}
