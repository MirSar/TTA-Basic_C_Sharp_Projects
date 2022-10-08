using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Assignment 10 - DateTime submission");
            Console.WriteLine("*************************************\n");
            try
            {
                // 1. Prints the current date and time to the console.
                DateTime currentTime = DateTime.Now;
                Console.WriteLine("The current date and time is " + currentTime.ToString());

                // 2. Asks the user for a number.
                Console.WriteLine("Hi User, please enter your favorite whole number");
                int x = Convert.ToInt32(Console.ReadLine());

                // 3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
                // Adding the int to TimeSpan as hours
                TimeSpan hoursToAdd = new TimeSpan(x, 0, 0);
                // Addint TimeSpan in hours to the DateTime
                DateTime favHoursFromNow = DateTime.Now.Add(hoursToAdd);
                // Printing the result
                Console.WriteLine("{0} hours from now will be {1}", x.ToString(), favHoursFromNow);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an integer");
            }
            finally
            {
                // keep the console open
                Console.ReadLine();
            }
          
        }
    }
}
