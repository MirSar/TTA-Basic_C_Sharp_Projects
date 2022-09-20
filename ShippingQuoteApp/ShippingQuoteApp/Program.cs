using System;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Welcome to Package Express.\n" +
                "Please follow the instructions below.");
            Console.WriteLine("==================================");
            
            Console.WriteLine("Please enter the package weight (lbs):");
            double packageWeight = Convert.ToDouble(Console.ReadLine());
            // Checking for weight requirements
            if (packageWeight > 50)
            {
                Console.WriteLine("Error:\n" +
                    "Package is too heavy to be shipped via Package Express.\n" +
                    "Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width (inches):");
                double packageWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height (inches):");
                double packageHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length (inches):");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                // Calculating the total package size = length + girth
                double packageGirth = (2 * packageWidth) + (2 * packageHeight);
                double totalPackageSize = packageLength + packageGirth;

                // checking for size requirement
                if (totalPackageSize > 50)
                {
                    Console.WriteLine("Error:\n" +
                        "Package is too big to be shipped via Package Express.");
                }
                else
                {
                    // Generate the quote
                    double packageQuote = ((packageHeight * packageWidth * packageLength) * (packageWeight)) / 100;
                    // rounding the quote to 2 decimal places
                    packageQuote = Math.Round(packageQuote, 2);

                    Console.WriteLine("Your estimated total for shipping this package is:\n" +
                        "$" + packageQuote+ "\n" +
                        "Thank you! for shipping with Package Express");
                }
            }
            // keep the Console open
            Console.ReadLine();

        }
    }
}
