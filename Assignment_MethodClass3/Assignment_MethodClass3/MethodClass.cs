using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_MethodClass3
{
    public class MethodClass
    {
        public void methodClass1(int num1, int num2, out int total)
        {
            // Math operation on the first integer
            total = num1 + num2;

            // display the second integer to the screen
            Console.WriteLine("The second integer is {0}", num2);
           
        }
    }
}
