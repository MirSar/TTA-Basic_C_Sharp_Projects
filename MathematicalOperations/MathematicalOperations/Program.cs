using System;

namespace MathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Performing Mathematical Operations with C#");
            Console.WriteLine("************************************");
            
            // User input for num1 and num2
            Console.WriteLine("Enter the first number: ");
            string inum1 = Console.ReadLine();
            decimal num1 = Convert.ToDecimal(inum1);
            Console.WriteLine("Enter the second number: ");
            string inum2 = Console.ReadLine();
            decimal num2 = Convert.ToDecimal(inum2);

            // Mathematical Operations
            // Add two numbers and display the output in the console.
            decimal sum = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
            // Subtract two numbers and display the output in the console.
            decimal difference = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + difference);
            // Multiply two numbers and display the output in the console.
            decimal product = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + " = " + product);
            // Divide two numbers and display the output in the console.
            decimal division = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + division);

            // Keep the Console open
            Console.ReadLine();

            // String Concatenation
            Console.WriteLine("Write the first word:");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Write the second word:");
            string secondWord = Console.ReadLine();
            Console.WriteLine("your two words combined is \n" + firstWord + " " + secondWord);
            Console.ReadLine();
        }
    }
}
