using System;

namespace CallingMethodsSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Heading
            Console.WriteLine("*************************************");
            Console.WriteLine("Calling Methods Submission Assignment");
            Console.WriteLine("*************************************");


            // calling methods and passing parameters
            CalculationOfSquare areaSq = new CalculationOfSquare();
            CalculationOfSquare perimSq = new CalculationOfSquare();
            CalculationOfSquare diagonalSq = new CalculationOfSquare();

            // User input
            Console.WriteLine("Square wiz here :)  ...\n" +
                "What is the length of the square?");
            Console.Write(">>>  ");

            try
            {
                int side = Convert.ToInt32(Console.ReadLine());
                // Output heading
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("A square with sides of " + side + " units of length\n" +
                    "Will have the following properties:");
                Console.WriteLine("--------------------------------------\n");

                // passing parameter and recieving results
                int areaOfSq = areaSq.areaOfSquare(side);
                int perimeterOfSq = perimSq.perimeterOfSquare(side);
                int diagonalOfSq = diagonalSq.diagonalOfSquare(side);

                // Output results
                Console.WriteLine("The area of the square is =  " + areaOfSq);
                Console.WriteLine("The perimeter of the square is =  " + perimeterOfSq);
                Console.WriteLine("The diagonal length of the square is =  " + diagonalOfSq);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("\nFormat Error: "+ex.Message);
                Console.WriteLine(">>> We only take whole numbers (integers)\n");
            }
            finally
            {
                Console.WriteLine("\nThank you and Goodbye for now.");
                Console.WriteLine("<Press Enter to Exit>");
            }

         

            // keep console open
            Console.ReadLine();

        }

    }
}
