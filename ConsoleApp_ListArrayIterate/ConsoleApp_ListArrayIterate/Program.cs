using System;
using System.Collections.Generic; // for Lists


namespace ConsoleApp_ListArrayIterate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Arrays, Lists, and Iteration Assignment");
            Console.WriteLine("***************************************\n");
            //******Part One:*********
            // 1. Create a one-dimensional array of strings
            string[] randWords = { "awesome", "happy", "grateful", "on a roll", "surprised", "amazing" };
            
            // 2. Ask the user to input some text
            Console.WriteLine("what is your name?");
            string userName = Console.ReadLine();
            
            // 3. A loop that iterates through each string in the array
            for (int i=0; i< randWords.Length; i++)
            {
                // and adds the user's text input.
                // update each array element by appending the user's text.
                randWords[i] = userName + " is " + randWords[i];
            }

            // 4. Create a second loop that prints off each string in the array one at a time.
            for (int i = 0; i < randWords.Length; i++)
            {
                Console.WriteLine(randWords[i]);
            }

            // Keep the Console open
            Console.ReadLine();

            //******Part Two:*********
            // 1. Add an infinite loop
            // Echo code
            Console.WriteLine("Wanna play the Echo game?\n(type 'yes' to play)");
            string wannaPlay = Console.ReadLine();
            
            if (wannaPlay.ToLower() == "yes")
            {
                Console.WriteLine("\nYour are standing on top of a mountian.\n" +
                    "You take a deep breath and yell out '__?__'");
                // To prevent Infinit loop include quit option
                Console.WriteLine("(to quit type 'stop')");

                while (true)
                {
                    Console.Write("\nYou take a deep breath and yell out ?>>> ");
                    string input = Console.ReadLine();

                    // This if statement adds an option to quit out of the infinit loop
                    if (input.ToLower() == "stop")
                    {
                        Console.WriteLine("\nThank you for playing. Goodby "+userName+"!");
                        break;
                    }

                    //Echo displayed
                    Console.WriteLine("\nA sec later you hear >>> " + input.ToUpper() + "... " + input.ToUpper() + "... " + input.ToUpper());
                }

            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
            
            Console.ReadLine();
        }
    }
}
