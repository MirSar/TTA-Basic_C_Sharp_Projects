using System;
using System.Collections.Generic;
using System.Text;

namespace Game_TwentyOne_ConsoleApp
{
    // Design tip: design towards abstraction
    public class Game
    {
        // General methods for a given game
        // A list of Players
        public List<string> Players{ get; set; }
        // Name of the game
        public string Name { get; set; }
        // A Dealer
        public string Dealer { get; set; }

        // Prints a list of players
        public void ListPlayers() // doesn't return
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
