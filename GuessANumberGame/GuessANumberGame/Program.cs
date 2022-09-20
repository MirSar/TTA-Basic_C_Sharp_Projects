using System;

namespace GuessANumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Welcome to the guessing game... let's play!");
            Console.WriteLine("-------------------------------------------");

            // Get players name
            string playerName = "";
            Console.WriteLine("What's your name player?");
            playerName = Console.ReadLine();

            // while loop to check if name is entered
            while (playerName == "")
            {
               Console.WriteLine("What's your name player?");
               playerName = Console.ReadLine();
            }
            Console.WriteLine("Welcome " + playerName + "! Let's play.");

            // create a random number to guess
            Random rnd = new Random();
            int secretNum = rnd.Next(0, 101);

            // Asking the user to make a guess
            Console.WriteLine(playerName + ", guess my number.\n" +
                "Here is a clue: the number ranges from 0 to 100.");
            int guessedNum = Convert.ToInt32(Console.ReadLine());

            // Used for while loop 
            bool isGuessed = guessedNum == secretNum;
            // Keeps count of guesses
            int counter = 1;

            do
            {
                // game logic
                if (guessedNum > secretNum)
                {
                    Console.WriteLine("You guessed too high! try again");
                    guessedNum = Convert.ToInt32(Console.ReadLine());
                    counter += 1;
                }
                else if (guessedNum < secretNum)
                {
                    Console.WriteLine("You guessed too low! try again");
                    guessedNum = Convert.ToInt32(Console.ReadLine());
                    counter += 1;
                }
                else
                {
                    Console.WriteLine(playerName+ ", you guessed right!\n" +
                        "The secret number was "+secretNum+ "\n" +
                        "It took you "+ counter+" tries.");
                    isGuessed = true;
                }
            }
            while (!isGuessed);

            // keep the console open
            Console.ReadLine();
        }
    }
}
