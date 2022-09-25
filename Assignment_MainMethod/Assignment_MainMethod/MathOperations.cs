using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_MainMethod
{
    public class MathOperations
    {
        // This method converts stones to pounds
        public int stoneTolbs (int stone)
        {
            int pounds = stone * 14;
            return pounds;
        }

        // Using method overloading for the second method
        public int stoneTolbs (decimal pounds)
        {
            int stones = (int)pounds/14;
            return stones;
        }

        // Using mehtod overloading for the third method
        public int stoneTolbs(string userInput, out int randNum)
        {
            // diffeent code ... adds the user number to a Random generated number

            // generate a random number
            Random random = new Random();
            int randNum1 = random.Next(0, 100);
            // need to send this out before the method can close (return total)
            randNum = randNum1;
            // Add the two
            int x = Convert.ToInt32(userInput);
            int total = x + randNum1;
   
            // output
            return total;
        }


    }
}
