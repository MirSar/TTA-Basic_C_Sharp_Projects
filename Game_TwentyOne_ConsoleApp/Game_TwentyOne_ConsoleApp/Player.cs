using System;
using System.Collections.Generic;
using System.Text;

namespace Game_TwentyOne_ConsoleApp
{
    public class Player
    {
        // Creating a constructor
        public Player (string name, int beginningBalance)
        {
            // Initialize Card List...Create an empty Card List
            Hand = new List<Card>();
            // Assign values to the properties of this object
            Balance = beginningBalance;
            Name = name;
        }

        // Properties that a player can have
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        
        // Adding an Overloaded Operator "+" so we can add players
        public static Game operator+ (Game game, Player player)
        {
            // Adding our own implementation
            game.Players.Add(player);
            return game;
        }

        // Adding an Overloaded Operator "-" so we can remove players from the list
        public static Game operator - (Game game, Player player)
        {
            // Adding our own implementation
            game.Players.Remove(player);
            return game;
        }

    }
}
