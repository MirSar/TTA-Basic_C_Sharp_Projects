using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Method2
{
    public class Mathematics
    {
        // Method 1... Note we are choosing an unlikely number for default value of num2 (golden ratio)
        public decimal areaMethod(decimal num1, decimal num2= 1.618033988m)
        {
            decimal side1 = num1;
            decimal side2 = num2;
            if (side2 != 1.618033988m && num1!=num2)
            {
                // rectangle
                decimal area = side1 * side2;
                Console.WriteLine("\nRectangle");
                return area;
            }
            else
            {
                // square
                decimal area = side1*side1;
                Console.WriteLine("\nSquare");
                return area;
            }

        }
    }
}
