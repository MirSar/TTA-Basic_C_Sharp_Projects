using System;
using System.IO; // For IO of text files

namespace Assignment_9_InputToTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Asks the user for a number.
            Console.WriteLine("Hello User!\n");
            Console.WriteLine("Please enter a number to be logged");
            string userNumber = Console.ReadLine();

            //2. Logs that number to a text file.
            File.WriteAllText(@"C:\Users\mirwa\OneDrive\Documents\2 GitHub\TTA-Basic_C_Sharp_Projects\Assignment_9-InputToTextFile\logFile.txt", userNumber);

            // 3. Prints the text file back to the user.
            string readTextFile = File.ReadAllText(@"C:\Users\mirwa\OneDrive\Documents\2 GitHub\TTA-Basic_C_Sharp_Projects\Assignment_9-InputToTextFile\logFile.txt");
            Console.WriteLine(readTextFile);

            // Keep the console open
            Console.ReadLine();
        }
    }
}
