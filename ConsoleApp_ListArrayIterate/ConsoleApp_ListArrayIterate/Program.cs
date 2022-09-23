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
            for (int i = 0; i < randWords.Length; i++)
            {
                // and adds the user's text input.
                // update each array element by appending the user's text.
                randWords[i] = userName + " is " + randWords[i];
            }

            // 4. Create a second loop that prints off each string in the array one at a time.
            for (int i = 0; i < randWords.Length; i++)
            {
                Console.WriteLine("\n" + randWords[i]);
            }

            Console.WriteLine("__________________________________________________________");

            //******Part Two:*********
            // 1. Add an infinite loop
            // Echo code
            Console.WriteLine("Wanna play the Echo game?\n(type 'yes' to play)");
            string wannaPlay = Console.ReadLine();

            if (wannaPlay.ToLower() == "yes")
            {
                // To prevent Infinit loop include quit option
                Console.WriteLine("That's the spirit! (to quit type 'stop')");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Your are standing on top of a mountian.\n");

                while (true)
                {
                    Console.Write("You take a deep breath and yell out ?>>> ");
                    string input = Console.ReadLine();

                    // This if statement adds an option to quit out of the infinit loop
                    if (input.ToLower() == "stop")
                    {
                        Console.WriteLine("\nThank you for playing. Goodby " + userName + "!");
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

            Console.WriteLine("__________________________________________________________");

            //******Part Three:*********
            //1. A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.

            // set the initial state
            int counter = 1;
            // ask for user input
            Console.WriteLine(userName + ", what is your favorite integer number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Also, what is your favorite word or phrase?");
            string favWord = Console.ReadLine();

            do
            {
                // counting up to the favorite number
                Console.Write(counter + "-" + favWord + " ");
                // increment the counter
                counter += 1;
            }
            while (counter < favNum);

            //3. Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator
            int counter2 = 1;
            Console.WriteLine("\n");
            Console.WriteLine("Oh my! that list didn't include " + userName + "'s favorite number!\n" +
                "That's not right... Let's fix that.\n");
            do
            {
                // counting up to the favorite number
                Console.Write(counter2 + "-" + favWord + " ");
                // increment the counter
                counter2 += 1;
                if (counter2 == favNum)
                {
                    Console.WriteLine("\nAnd " + userName + "'s favorite number ");
                }
            }
            while (counter2 <= favNum);
            Console.WriteLine("\n");
            Console.WriteLine("__________________________________________________________");


            //******Part Four:*********
            //1. A list of strings where each item in the list is unique. 
            List<string> cSharpKeywords = new List<string>()
            {
                "abstract","as",
                "bool","break","byte",
                "case","catch","char","checked","class","const","continue",
                "decimal","default","delegate","do", "double",
                "else", "enum","event","explicit","extern",
                "false","file","finally","fixed","float","for","foreach",
                "goto",
                "if","implicit","in","int","interface","internal","is",
                "lock","long",
                "namespace","new","null",
                "object","operator","out","override",
                "params","private","protected","public",
                "readonly","ref","return",
                "sbyte","sealed","short","sizeof","stackalloc", "static","string","struct","switch",
                "this","throw","true","try","typeof",
                "uint","ulong","unchecked","unsafe","ushort","using",
                "virtual","void","volatile",
                "while",
            };

            //2. Ask the user to input text to search for in the list.
            Console.WriteLine(userName + ", Let's review your knowledge of C# keywords!\n");
            Console.WriteLine("Note: These Keywords are predefined, reserved identifiers that have special meanings to the compiler.");
            Console.WriteLine("Let's begin :) \n");

            bool guessedCorrectly = false;
            do
            {
                Console.Write("Type a C# keyword and I'll tell you if it is on my list >>> ");
                string userGuessedKeyword = Console.ReadLine();

                //3. A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
                int index = 0;
                foreach (string cSharpkeyword in cSharpKeywords)
                {
                    if (cSharpkeyword == userGuessedKeyword.ToLower())
                    {
                        Console.WriteLine(".....................................");
                        Console.WriteLine(userGuessedKeyword + " is on the List!\n" +
                            "That keyword is number " + (index + 1) + " out of " + cSharpKeywords.Count);
                        Console.WriteLine(".....................................");

                        //5. Add code that stops the loop from executing once a match has been found.
                        guessedCorrectly = true;
                    }
                    index += 1;
                }
                //4. Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list. 
                if (!cSharpKeywords.Contains(userGuessedKeyword))
                {
                    Console.WriteLine(".....................................");
                    Console.WriteLine(userGuessedKeyword + " is NOT on the List!");
                    Console.WriteLine(".....................................");
                }
            }
            while (!guessedCorrectly);

            Console.WriteLine("__________________________________________________________");

            //******Part Five:*********
            //1. A list of strings that has at least two identical strings in the list.
            List<string> colorList = new List<string>()
            {
                "red", "green","blue","black", "white", "yellow",
                "red", "purple", "green", "orange", "gray",
                "blue"
            };

            //1. Ask the user to select text to search for in the list.
            Console.WriteLine("I have a list of colors, give me a color to search for in my list");
            string userSelectText = Console.ReadLine();
            int indexColor = 0;
            //2. Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text.
            //Ensure to remove any break statements that may prevent your code from returning multiple matches.
            foreach (string color in colorList)
            {
                if (userSelectText.ToLower() == color)
                {
                    Console.WriteLine("\nThe following match is found:");
                    Console.WriteLine(color + " is in the list at list index of " + indexColor);
                }
                indexColor += 1;
            }

            //3. Add code to the loop to check if the user put in text that isn't on the list and,
            //if they did, tells the user their input is not on the list.
            //(You do not need to provide any additional chances for the user to enter text.)
            if (!colorList.Contains(userSelectText))
            {
                Console.WriteLine(".....................................");
                Console.WriteLine(userSelectText + " is NOT on the List!");
                Console.WriteLine(".....................................");
            }
            Console.WriteLine("Goodbye! " + userName);

            Console.WriteLine("__________________________________________________________");

            //******Part Six:*********
            //1. Create a list of strings that has at least two identical strings in the list.
            List<string> uniqueOrDupList = new List<string>()
            {
                "red", "green","blue","black", "white", "yellow",
                "red", "purple", "green", "orange", "gray",
                "blue"
            };
            // creating an empty list container
            List<string> duplicateFinder = new List<string>();

            //2. Create a foreach loop that evaluates each item in the list,
            //and displays a message showing the string and whether or not it has already appeared in the list.
            foreach (string uniqueOrDup in uniqueOrDupList)
            {
                if (!duplicateFinder.Contains(uniqueOrDup))
                {
                    duplicateFinder.Add(uniqueOrDup);
                    Console.WriteLine(uniqueOrDup + " - this item is unique");
                }
                else
                {
                    Console.WriteLine(uniqueOrDup + " - this item is a duplicate");
                }
            }


            // Keep the Console open
            Console.ReadLine();
        }
    }
}
