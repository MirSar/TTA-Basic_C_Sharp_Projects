using System;

namespace Assignment_Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Method Submission Assignment2");
            Console.WriteLine("*******************************");

            // instantiating the class
            Mathematics mathematics = new Mathematics();

            // User Input. For the required first number
            try
            {
                Console.WriteLine("We will be calculating the area of a square or rectangle\n" +
                    "Enter the length of the side or sides:\n");
                Console.Write("Required: Please enter the length of the first side? >>> ");
                decimal userInput1 = Convert.ToDecimal(Console.ReadLine());
                
                // Usr Input. For Optional second number
                // keeping this inside the first try so we can pass on the userInput1 paramenter
                try
                {
                    Console.WriteLine("\nOptional second side entry: " +
                        "To skip press ENTER.");
                    Console.Write("What is the length of the second side? >>> ");
                    string userInput3 = Console.ReadLine();
                    decimal userInput2 = Convert.ToDecimal(userInput3);
                    decimal areaSq = mathematics.areaMethod(userInput1, userInput2);
                    Console.WriteLine("\nThe area of the Quadrilateral  shape is {0}", areaSq);
                }
                catch (Exception ex)
                {
                    decimal areaSq = mathematics.areaMethod(userInput1);
                    Console.WriteLine("\nThe area of the Quadrilateral  shape is {0}", areaSq);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a number.");
            }
            finally
            {
                Console.ReadLine();
            }

            // Alternative method
            //// User Interaction
            //try
            //{
            //    Console.WriteLine("We will be calculating the area of a square or rectangle\n" +
            //        "Enter the length of the side or sides:\n");
            //    Console.Write("Required: Please enter the length of the first side? >>> ");
            //    decimal userInput1 = Convert.ToDecimal(Console.ReadLine());

            //    Console.WriteLine("\nOptional second side entry: " +
            //        "To skip press ENTER.");
            //    Console.Write("What is the length of the second side? >>> ");
            //    string userInput3 = Console.ReadLine();

            //    if (userInput3 != "")
            //    {
            //        decimal userInput2 = Convert.ToDecimal(userInput3);
            //        decimal areaSq = mathematics.areaMethod(userInput1, userInput2);
            //        Console.WriteLine("\nThe area of the Quadrilateral  shape is {0}", areaSq);
            //    }
            //    else
            //    {
            //        decimal areaSq = mathematics.areaMethod(userInput1);
            //        Console.WriteLine("\nThe area of the Quadrilateral  shape is {0}", areaSq);
            //    }

            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}


        }
    }
}
