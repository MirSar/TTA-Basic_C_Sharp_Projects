using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_MethodClass4
{
    public class HalfIt
    {
        // create a void method that outputs an integer.
        public void HalvedInteger(int num)
        {
            // Have the method divide the data passed to it by 2.
            int output = num / 2;

            // Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine("half of {0} is {1} (as an integer output)",num,output);
        }

        // Create a method with output parameters.
        public decimal PrecisedDivision(decimal num)
        {
            decimal output = num / 2;
            return output;
        }

        // Overload a method
        public decimal PrecisedDivision(decimal num, decimal num2 = 2)
        {
            // math calculation
            decimal output = num / num2;
            // Round the decimal place to 3 digits
            output = Math.Round(output, 3);
            return output;
        }



    }
}
