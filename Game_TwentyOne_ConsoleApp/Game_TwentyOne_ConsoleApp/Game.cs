using System;
using System.Collections.Generic;
using System.Text;

namespace Game_TwentyOne_ConsoleApp
{
    // Design tip: design towards abstraction
    // Note we can NOT instantiate Game only inherit from
    public abstract class Game
    {
        // General properties for any given game
        public List<string> Players{ get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }


        // Methods for games
        // Creating an abstract method for play
        public abstract void Play();


        // Virtual keyword makes this a virtual method
        // This method gets inherited but can be overridden 
        public virtual void ListPlayers()
        {
            Console.WriteLine("========================");
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine("========================\n");

        }

    }
}
