using System;

namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            // Console.ReadLine() keeps the console window open
            // it makes the console read the input, then display it
            string name = Console.ReadLine();
            Console.WriteLine("Peace, " + name + "!");
            Console.ReadLine();
        }
    }
}
