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
            // Need this outside of this constructor : public List<Card> Cards {get; set;}
            // Instantiates its property 'Cards' as an empty List<Card>
            Cards = new List<Card>();
           
            // Creating 2 more lists and instantiating them with values
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
                    // creating a new object of class Card, which exists only in this loop
                    Card card = new Card();
                    // assign values of items from our two lists 
                    card.Suit = suit; 
                    card.Face = face;
                    // add into our global Cards list
                    Cards.Add(card);
                }
            }

        }

        // This Class makes Cards ==> Creating Properties
        public List<Card> Cards { get; set; }



    }
}
