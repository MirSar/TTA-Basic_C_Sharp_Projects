using System;
// for list
using System.Collections.Generic;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("Console App Array Assignment");
            Console.WriteLine("******************************************");

            // 1. one-dimensional array of string
            string[] powerAnimals = {"Bumblebee", "Peregrine Falcon", "Sloth", "Reindeer", "Lyrebird"};
            
            Console.WriteLine("Let's see which power animal chooses you");
            int powerAnimIndex;
            bool correctInput = false;

            while (!correctInput) // this loop will continue until the user enters a number
            {
                Console.WriteLine("Give me a number from 0 to 4");
                correctInput = int.TryParse(Console.ReadLine(), out powerAnimIndex); // if the parsing was successful it returns true

                if (!correctInput)
                {
                    Console.WriteLine("Your input was not a number");
                }
                else
                {
                    // 3. checking for correct range of 0-4
                    while (powerAnimIndex < 0 || powerAnimIndex > 4)
                    {
                        Console.WriteLine("Please enter a number from 0 to 4 only!");
                        powerAnimIndex = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("Your power animal is: " + powerAnimals[powerAnimIndex]);
                    Console.ReadLine();
                }
                
            }


            //2. one-dimensional array of integers
            int[] powerNums = {1,3,6,9,13,27,69,114};
            
            int powerNumIndex;
            Console.WriteLine("Let's see which lucky number chooses you");

            do
            {
                Console.WriteLine("Give me a number from 0 to 7");
                correctInput = int.TryParse(Console.ReadLine(), out powerNumIndex); // if the parsing was successful it returns true

                if (!correctInput)
                {
                    Console.WriteLine("Your input was NOT an integer!");
                }
                else
                {
                    // 3. checking for correct range of 0-7
                    while (powerNumIndex < 0 || powerNumIndex > 7)
                    {
                        Console.WriteLine("Please enter a number from 0 to 7 only!");
                        powerNumIndex = Convert.ToInt32(Console.ReadLine());
                    }
         
                    Console.WriteLine("Your lucky number is: " + powerNums[powerNumIndex]);
                    Console.ReadLine();
                }
            }
            while (!correctInput); // this loop will continue until the user enters a number

            //4. Create a list of strings
            //adding elements using collection-initializer syntax
            var compliments = new List<string>()
            {
                "You’re a smart cookie",
                "You look great today",
                "I like your style",
                "You have the best laugh",
                "I appreciate you",
                "You are making a difference",
                "You’re a candle in the darkness"
            };

            int compIndex;
            Console.WriteLine("I have something to say to you.");

            do
            {
                Console.WriteLine("Give me a number from 0 to 6");
                correctInput = int.TryParse(Console.ReadLine(), out compIndex); // if the parsing was successful it returns true

                if (!correctInput)
                {
                    Console.WriteLine("Your input was NOT an integer!");
                }
                else
                {
                    while (compIndex < 0 || compIndex > 6)
                    {
                        Console.WriteLine("Please enter a number from 0 to 6 only!");
                        compIndex = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("I just gotta say, " + compliments[compIndex]);
                    Console.ReadLine();
                }
            }
            while (!correctInput); // this loop will continue until the user enters a number


        }
    }
}
