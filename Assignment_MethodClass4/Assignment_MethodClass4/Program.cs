using System;

namespace Assignment_MethodClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("Assignment Class Submission");
            Console.WriteLine("*********************************");

            // Instantiating the class HalfIt.
            HalfIt halfIt = new HalfIt();

            // Have the user enter a number. 
            Console.Write("User, enter a number >>>");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Call the method on that number.
            halfIt.HalvedInteger(userNum);

            // Calling precisedDivision method.
            decimal precisedDivOutput = halfIt.PrecisedDivision(userNum);
            Console.WriteLine("Output from precisedDivision method is {0}", precisedDivOutput);

            // User Input for calling overloaded PrecisedDivision method.
            Console.WriteLine("..............................");
            Console.Write("Let's divid it by another number.\n" +
                "What number do you want to divide it by? >>> ");
            decimal userDivideByNum = Convert.ToDecimal(Console.ReadLine());

            // Calling the overloaded PrecisedDivision mehtod.
            decimal overloadedOutput = halfIt.PrecisedDivision(userNum, userDivideByNum);
            // Output.
            Console.WriteLine("{0} divided by {1} = {2}",userNum,userDivideByNum, overloadedOutput);

            // Using the static mehtod.
            Console.WriteLine("..............................");
            decimal myStaticOutput = ThisStaticMethod(userNum, userDivideByNum);
            Console.WriteLine("{0} divided by {1} = {2}", userNum, userDivideByNum, myStaticOutput);

            // Keep the console open.
            Console.ReadLine();

        }

        // Creating a Static method.
        public static decimal ThisStaticMethod(decimal num, decimal num2 = 1)
        {
            // Prints out a statement 
            Console.WriteLine("This is a statement from the Static mehtod:");
            decimal output = num / num2;
            return output;
        }

    }
}
