using System;
using System.Collections.Generic; // for list


namespace Iteration
{
    class Program
    {
        static void Main(string[] args) // note we can pass parameters from cmd line
        {
            Console.WriteLine("Iteration samples:\n");
            //// Example 1:
            //// creating and instantiating an Array
            //int[] testScore = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            //// for loop
            //for (int i=0; i< testScore.Length; i++)
            //{
            //    if (testScore[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScore[i]);
            //    }
            //}
            //// keep the console open
            //Console.ReadLine();

            //// Example 2:
            //string[] names = { "Mir", "Mark", "Steve", "Jesse", "Erik" };
            //for (int j=0; j < names.Length; j++)
            //{
            //    // print the list
            //    Console.WriteLine(names[j]);

            //    // if statement kicks in once requirement is met
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine("TTA instructor " + names[j] + " is in the house!");
            //    }
            //}
            //// Keep Console open
            //Console.ReadLine();

            //// Example 3: iteration of List

            //List<int> testScores = new List<int>(); // creates the List
            //// manually adding to the List
            //testScores.Add(13);
            //testScores.Add(86);
            //testScores.Add(3);
            //testScores.Add(1);
            //testScores.Add(114);
            //// Iterating through the List using a foreach loop
            //foreach(int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test Score: " + score);
            //    }
            //}
            //// Keep the Console open
            //Console.ReadLine();

            //// Example 4: list<string>
            //// create and instantiate
            //List<string> names = new List<string>() { "Mir", "Mark", "Steve", "Jesse", "Erik" };
            //// Loop using foreach loop (avail for Lists)
            //foreach (string name in names)
            //{
            //    //List all of the names in the list
            //    Console.WriteLine(name);
            //    // specific if statement
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine("TTA " + name + " is teaching!");
            //    }
            //}
            //Console.ReadLine();

            // Example 5: Iterate the list and if it meets a condition then
            // add that item to another list

            List<int> testScores = new List<int>() { 98, 82, 76, 91, 98, 99, 75, 86, 91, 85 };
            // creating an empty List... note we don't have to set the size
            List<int> passingScores = new List<int>();
            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            // How many scores passed?
            Console.WriteLine(passingScores.Count+ " passed out of "+ testScores.Count);
            Console.ReadLine();
                    






        }
    }
}
