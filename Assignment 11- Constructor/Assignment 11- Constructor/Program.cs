using System;

namespace Assignment_11__Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 1. Create a const variable
            const string assignment = "Assignment 11 - Constructor";
            Console.WriteLine(assignment+ "\n");

            try
            {
                // 2. Create a variable using the keyword “var.”
                Console.Write("What is your name? >>> ");
                var userName = Console.ReadLine();
                if (userName == "")
                {
                    Console.WriteLine("Keeping it mysterious... that's cool.");
                    userName = "Mysterious person";
                }
                else
                {
                    Console.WriteLine("{0} is a great name!!\n", userName);
                }               

                // 3. Chain two constructors together.
                // Instantiating the class
                Console.WriteLine("What is your favorit food? \nOr push enter and I'll suggest you one.");
                string favFood = Console.ReadLine();
                if (favFood == "")
                {
                    UserConstructor userSuggest = new UserConstructor(userName);
                }
                else
                {
                    UserConstructor userWithTaste = new UserConstructor(userName, favFood);
                }            
                
            }
            catch (Exception)
            {
                Console.WriteLine("error detected... try again");
            }
            finally
            {
                // Keep the Console Open
                Console.ReadLine();
            }
            
        }
        
        
    }
}
