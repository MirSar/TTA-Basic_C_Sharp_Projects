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
        private List<Card> _hand = new List<Card>();

        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        
        // Bet Method
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet of that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

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
