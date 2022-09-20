using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When if/else gets tedious, switch :)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Guess a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number==13;
            do
            {
                // switch statement
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("You guessed 13. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            // keep the console open
            Console.ReadLine();
        }
    }
}
