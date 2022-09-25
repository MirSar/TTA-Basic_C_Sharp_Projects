using System;

namespace Assignment_MethodClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("Assignment Method Class Submission");
            Console.WriteLine("*****************************************");

            // instantiating the class
            MethodClass methodClass = new MethodClass();

            int total;
            // Call the method in the class, passing in two numbers.
            methodClass.methodClass1(13, 9, out total);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("If the sum of the two integers is {0}\n" +
                "What is the first integer?", total);
            Console.WriteLine("-----------------------------------");


            // Call the method in the class, specifying the parameters by name.
            methodClass.methodClass1(num1: 27, num2: 114, out total);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("If the sum of the two integers is {0}\n" +
                "What is the first integer", total);
            Console.WriteLine("-----------------------------------");

            Console.ReadLine();
        }
    }
}
