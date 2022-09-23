using System;
using System.Collections.Generic; // for Lists


namespace StringsAndIntegersSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("String and Integer Submission Assignment");
            Console.WriteLine("****************************************");

            // List of prime numbers from 1-100
            List<int> primeNumList = new List<int>()
            {
                2, 3, 5, 7,
                11, 13, 17, 19,
                23, 29,
                31, 37,
                41, 43, 47,
                53, 59,
                61, 67,
                71, 73, 79,
                83, 89,
                97
            };

            // Putting the loop in a try/catch block.
            try
            {
                // Asking the user for a number
                Console.WriteLine("I have a list of prime numbers from 1 - 100.\n" +
                    "Give me a number and I'll divide it to each of my prime numbers.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                // Write a loop that takes each integer in the list,
                foreach (int primeNum in primeNumList)
                {
                    // divides it by the number the user entered,
                    int resultDivided = primeNum / userNumber;
                    // get the remainder
                    int remainder = primeNum % userNumber;

                    // and displays the result to the screen.
                    Console.WriteLine(primeNum + " divided by " + userNumber + " = " + resultDivided + " with a remainder of " + remainder);
                }
            }
            catch (DivideByZeroException dbzex)
            {
                // DivideByZeroException
                Console.WriteLine(dbzex.Message);
                Console.WriteLine("That means enter a non-zero number!");
            }
            catch (FormatException fex)
            {
                // FormatException
                Console.WriteLine(fex.Message);
                Console.WriteLine("That means enter a whole number (integers)!");
            }
            finally
            {
                // Keep the Console Open
                Console.ReadLine();
            }

            // message to the display to let you know the program has emerged
            // from the try/catch block and continued on with program execution
            Console.WriteLine("Thank you and Goodbye :)");
            // Keep the Console Open
            Console.ReadLine();
        }
    }
}
