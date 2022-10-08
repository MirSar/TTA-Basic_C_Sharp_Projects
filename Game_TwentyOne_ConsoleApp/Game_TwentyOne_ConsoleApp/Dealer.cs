using System;
using System.Collections.Generic;
using System.Linq; // Needed for access to first() in "Deck.Cards.First()"
using System.Text;
using System.IO; // Needed for logging

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

            // Everytime a card is dealt we will log it to our log file.
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            // displaying the card we added to the hand
            Console.WriteLine(card);
            //// Logging the cards dealt using append
            //using (StreamWriter file = new StreamWriter(@"C:\Users\mirwa\OneDrive\Documents\2 GitHub\TTA-Basic_C_Sharp_Projects\Game_TwentyOne_ConsoleApp\LogFolder\logCardsDealt.txt", true))
            //{
            //    file.WriteLine(card);
            //}

            // Removing the card we picked from the Deck
            Deck.Cards.RemoveAt(0); // removing the first item
        }

    }
}
