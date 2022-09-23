using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int divResult = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " = " + divResult);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dividing by zero is not allowed");
            }
            // general exception catch
            catch (Exception ex)
            {
                Console.WriteLine("This is a general exception handle message");
                Console.WriteLine(ex.Message);
            }
            finally // will always run
            {
                Console.ReadLine();
                // log to database
            }

            
        }
    }
}
