using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            // Using StudentScore file to calculate the average score
            // file path
            string path = @"C:\Users\mirwa\OneDrive\Documents\2 GitHub\TTA-Basic_C_Sharp_Projects\Scores\Scores\studentScores.txt";
            // Create an array to store our studentScores data
            string[] lines = System.IO.File.ReadAllLines(path);

            // initialize our score variable
            double tScore = 0;
            
            Console.WriteLine("\nStudent Scores:\n");
            // iterate the array
            foreach (string line in lines)
            {
                // print the data on the console
                Console.Write("\n" + line);
                // Convert datatype for computation
                double score = Convert.ToDouble(line);
                // Calculate the total score
                tScore += score;
            }
            // Find the average 
            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores.\tAverage score: " + avgScore);

            // keep the console open
            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
