using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11__Constructor
{
    public class UserConstructor
    {
        public string userName;
        public string favFood;

        // 3. Chain two constructors together.
        
        public UserConstructor(string userName):this (userName, "eggplant")
        {
        }
        public UserConstructor(string userName, string favFood)
        {
            Console.WriteLine("{0} loves to eat {1}", userName, favFood);
        }
    }
}
