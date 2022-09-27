using System;
using System.Collections.Generic;
using System.Linq; // Needed for access to first() in "Deck.Cards.First()"
using System.Text;

namespace Game_TwentyOne_ConsoleApp
{
    public class Dealer
    {
        // Dealer properties.
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        // Dealer Methods.
        public void Deal (List<Card> Hand)
        {
            // Adding to Hand...taking the first card from the deck
            // adding it to the Hand
            Hand.Add(Deck.Cards.First());
            // displaying the card we added to the hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");

            // Removing the card we picked from the Deck
            Deck.Cards.RemoveAt(0); // removing the first item
        }

    }
}
