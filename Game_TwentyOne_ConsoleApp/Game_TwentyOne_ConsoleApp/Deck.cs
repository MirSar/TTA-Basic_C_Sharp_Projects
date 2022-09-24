using System;
using System.Collections.Generic;
using System.Text;

namespace Game_TwentyOne_ConsoleApp
{
    // Making it public
    public class Deck
    {
        // Creating a Constructor (which assigns value upon creation of the class object)
        public Deck() // Same name as its class
        {
            // Instantiates its property 'Cards' as an empty List<Card>
            Cards = new List<Card>();
           
            // Creating 2 more lists and isntantiating them with values
            List<string> Suits = new List<string>()
            {
                "Clubs","Hearts","Dimonds","Spades"
            };

            List<string> Faces = new List<string>()
            {
                "Two","Three","Four","Five","Six","Seven",
                "Eight","Nine","Ten","Jack","Queen","King","Ace"
            };

            // using a nested foreach loop to create 52 cards
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    // creating a new card which exists only in this loop
                    Card card = new Card();
                    // assign values
                    card.Suit = suit;
                    card.Face = face;
                    // add into our cards list
                    Cards.Add(card);
                }
            }

        }

        // Creating Properties
        public List<Card> Cards { get; set; }

    }
}
